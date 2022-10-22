/*
	Created By		:	Tu Nguyen
	Created Date	:	Sep 19, 2022
	Description		:	Book Management - Update data for Book table
*/

CREATE PROCEDURE [dbo].[spr_Book_UpdateData]
	@Id UNIQUEIDENTIFIER,
	@Name VARCHAR(250),
	@Author VARCHAR(250),
	@Description VARCHAR(MAX),
	@Quantity INT,
	@TypeOfBook TINYINT,
	@Price MONEY,
	@ModifiedBy UNIQUEIDENTIFIER
AS
BEGIN
	IF(@Name <> '')
	BEGIN
		UPDATE b
		SET b.[Name] = @Name
		FROM Book b
		WHERE b.Id = @Id
	END
	IF(@Author <> '')
	BEGIN
		UPDATE b
		SET b.Author = @Author
		FROM Book b
		WHERE b.Id = @Id
	END
	IF(@Description <> '')
	BEGIN
		UPDATE b
		SET b.Author = @Author
		FROM Book b
		WHERE b.Id = @Id
	END
		
	UPDATE b
	SET b.TypeOfBook = @TypeOfBook, b.ModifiedDate = GETDATE(), b.Price = @Price
		, b.ModifiedBy = @ModifiedBy, b.Quantity = @Quantity
	FROM Book b
	WHERE b.Id = @Id
END

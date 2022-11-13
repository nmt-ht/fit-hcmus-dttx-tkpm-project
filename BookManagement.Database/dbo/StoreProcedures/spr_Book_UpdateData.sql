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
	UPDATE b
	SET b.TypeOfBook = @TypeOfBook
		, b.ModifiedDate = GETDATE()
		, b.Price = @Price
		, b.Author = N'' + @Author + ''
		, b.[Name] = N'' + @Name + ''
		, b.Description = N'' + @Description + ''
		, b.ModifiedBy = @ModifiedBy
		, b.Quantity = @Quantity
	FROM Book b
	WHERE b.Id = @Id

	IF(EXISTS (SELECT 1 FROM Inventory WHERE Book_ID_FK = @Id))
	BEGIN
		UPDATE I
		SET I.AvailableQty = CASE WHEN (i.AvailableQty > @Quantity AND @Quantity > 0) THEN i.AvailableQty - @Quantity ELSE @Quantity END
		FROM Inventory i
		WHERE i.Book_ID_FK = @Id
	END
END

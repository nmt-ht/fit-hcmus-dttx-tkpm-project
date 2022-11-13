/*
	Created By		:	Tu Nguyen
	Created Date	:	Sep 19, 2022
	Description		:	Book Management - Insert data for Book table
*/
CREATE PROCEDURE [dbo].[spr_Book_InsertData]
	@Id UNIQUEIDENTIFIER,
	@Name VARCHAR(250),
	@Author VARCHAR(250),
	@Description VARCHAR(MAX),
	@Quantity VARCHAR(250),
	@TypeOfBook TINYINT,
	@Price MONEY,
	@CreatedBy UNIQUEIDENTIFIER
AS
BEGIN
	IF(EXISTS(SELECT 1 FROM Book WHERE Id = @Id))
	BEGIN
		UPDATE b
			SET b.TypeOfBook = @TypeOfBook
				, b.ModifiedDate = GETDATE()
				, b.Price = @Price
				, b.Author = N'' + @Author + ''
				, b.[Name] = N'' + @Name + ''
				, b.Description = N'' + @Description + ''
				, b.ModifiedBy = @CreatedBy
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
	ELSE
	BEGIN
		INSERT INTO [Book] (Id, [Name], [Author], [Description], Quantity, TypeOfBook, Price, IsDeleted, CreatedDate, CreatedBy)
		VALUES(@Id, N'' + @Name + '', N'' + @Name + '', N'' + @Description + '', @Quantity, @TypeOfBook, @Price, 0, GETDATE(), @CreatedBy)

		INSERT INTO Inventory(Id, AvailableQty, Book_ID_FK, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate, IsDeleted)
		SELECT NEWID(), @Quantity, @Id, @CreatedBy, GETDATE(), NULL, NULL, 0
	END
END

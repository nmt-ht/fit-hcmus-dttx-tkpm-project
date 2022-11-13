/*
	Created By		:	Tu Nguyen
	Created Date	:	Sep 19, 2022
	Description		:	Book Management - Update data for Book table
*/
CREATE PROCEDURE [dbo].[spr_Inventory_InsertData]
(
	@BookId UNIQUEIDENTIFIER,
	@OrderedQty INT,
	@CreatedBy UNIQUEIDENTIFIER
)
AS
BEGIN
	IF(NOT EXISTS(SELECT 1 FROM Inventory WHERE Book_ID_FK = @BookId))
	BEGIN
		INSERT INTO Inventory(Id, AvailableQty, Book_ID_FK, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate, IsDeleted)
		VALUES(NEWID(), @OrderedQty, @BookId, @CreatedBy, GETDATE(), NULL, NULL, 0)
	END
	ELSE
	BEGIN
		UPDATE i
		SET i.AvailableQty = i.AvailableQty + @OrderedQty
			, i.ModifiedBy = @CreatedBy
			, i.ModifiedDate = GETDATE()
		FROM Inventory i
		WHERE i.Book_ID_FK = @BookId
	END
END

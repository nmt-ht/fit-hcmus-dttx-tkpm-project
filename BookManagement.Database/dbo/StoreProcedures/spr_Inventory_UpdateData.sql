/*
	Created By		:	Tu Nguyen
	Created Date	:	Sep 19, 2022
	Description		:	Book Management - Update data for Book table
*/
CREATE PROCEDURE [dbo].[spr_Inventory_UpdateData]
(
	@InventoryId UNIQUEIDENTIFIER,
	@BookId UNIQUEIDENTIFIER,
	@OrderedQty INT,
	@ModifiedBy UNIQUEIDENTIFIER
)
AS
BEGIN
	UPDATE i
	SET i.AvailableQty = i.AvailableQty - @OrderedQty
		, i.ModifiedBy = @ModifiedBy
		, i.ModifiedDate = GETDATE()
	FROM Inventory i
	WHERE i.Id = @InventoryId AND i.Book_ID_FK = @BookId
END

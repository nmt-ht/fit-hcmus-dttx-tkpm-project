/*
	Created By		:	Tu Nguyen
	Created Date	:	Nov 16, 2022
	Description		:	Book Management - Insert data for Order Item table
*/
CREATE PROCEDURE [dbo].[spr_Receipt_Create]
(
	@Order_ID_FK UNIQUEIDENTIFIER,
	@TotalCustCost MONEY,
	@Status TINYINT
)
AS
BEGIN
	DECLARE @ReceiptId UNIQUEIDENTIFIER = NEWID();
	INSERT INTO Receipt(Id, CreatedDate, Order_ID_FK, TotalCustCost, [Status])
	VALUES(@ReceiptId, GETDATE(), @Order_ID_FK, @TotalCustCost, @Status)

	UPDATE cus
	SET cus.Debt = cus.Debt - r.TotalCustCost
	FROM Customer cus
	JOIN [Order] o ON o.Id = cus.Order_ID_FK
	JOIN Receipt r ON r.Order_ID_FK = o.Id
	WHERE r.Id = @ReceiptId AND o.Id = @Order_ID_FK
END
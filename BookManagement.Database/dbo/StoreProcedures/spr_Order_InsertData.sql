/*
	Created By		:	Tu Nguyen
	Created Date	:	Nov 13, 2022
	Description		:	Book Management - Insert data for Order table
*/
CREATE PROCEDURE [dbo].[spr_Order_InsertData]
(
	@Id UNIQUEIDENTIFIER = NULL,
	@Customer_ID_FK UNIQUEIDENTIFIER = NULL,
	@CreatedBy UNIQUEIDENTIFIER = NULL
)
AS
BEGIN
	DECLARE @OrderID VARCHAR(250) = 'ORD00';
	DECLARE @MaxId INT = 0;
	IF(NOT EXISTS (SELECT 1 FROM [Order]))
	BEGIN
		SET @MaxId = 1
	END
	ELSE
	BEGIN
		DECLARE @CurrentOrderId VARCHAR(250) = ''
		SELECT TOP 1 @CurrentOrderId = OrderId
		FROM [Order] o
		ORDER BY o.OrderDate DESC
		
		DECLARE @CurrentNumber INT = 0;
		SET @CurrentNumber =  CONVERT(INT, RIGHT(@CurrentOrderId, 2))
		SET @MaxId = @CurrentNumber + 1
	END

	SET @OrderID = @OrderID + CONVERT(VARCHAR(5), @MaxId)

	INSERT INTO [Order](Id, OrderId, TotalQuantity, TotalPrice, OrderDate, Customer_ID_FK, CreatedBy)
	VALUES(@Id, @OrderID, 0, 0, GETDATE(), @Customer_ID_FK, @CreatedBy)
END
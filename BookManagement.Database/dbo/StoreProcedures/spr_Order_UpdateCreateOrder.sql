/*
	Created By		:	Tu Nguyen
	Created Date	:	Nov 13, 2022
	Description		:	Book Management - Insert data for Order Item table
*/
 CREATE PROCEDURE [dbo].[spr_Order_UpdateCreateOrder]
(
	@Id UNIQUEIDENTIFIER = NULL	
)
AS
BEGIN
	DECLARE @TotalQuantity INT = 0;

	UPDATE I
	SET I.AvailableQty = I.AvailableQty - oi.Quantity
	FROM [Order] o
	JOIN OrderItem oi ON oi.Order_ID_FK = o.Id
	JOIN Inventory i ON i.Book_ID_FK = oi.Book_ID_FK
	WHERE o.Id = @Id
END
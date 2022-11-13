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
	DECLARE @TotalPrice MONEY = 0

	SELECT @TotalPrice = SUM(oi.Price), @TotalQuantity = SUM(oi.Quantity)
	FROM [Order] o
	JOIN OrderItem oi ON oi.Order_ID_FK = o.Id
	WHERE o.Id = @Id

	UPDATE O
	SET O.TotalQuantity = @TotalQuantity, o.TotalPrice = @TotalPrice
	FROM [Order] o
	WHERE o.Id = @Id
END
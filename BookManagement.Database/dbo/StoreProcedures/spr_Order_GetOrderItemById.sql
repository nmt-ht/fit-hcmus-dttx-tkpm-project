/*
	Created By		:	Tu Nguyen
	Created Date	:	Nov 13, 2022
	Description		:	Book Management - Insert data for Order Item table
*/
 CREATE PROCEDURE [dbo].[spr_Order_GetOrderItemById]
(
	@Id UNIQUEIDENTIFIER = NULL	
)
AS
BEGIN
	SELECT *
	FROM [OrderItem] o
	WHERE o.Order_ID_FK = @Id
END
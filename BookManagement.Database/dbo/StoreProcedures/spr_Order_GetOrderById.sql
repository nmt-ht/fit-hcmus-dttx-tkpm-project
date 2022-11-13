/*
	Created By		:	Tu Nguyen
	Created Date	:	Nov 13, 2022
	Description		:	Book Management
*/
 CREATE PROCEDURE [dbo].[spr_Order_GetOrderById]
(
	@Id UNIQUEIDENTIFIER = NULL	
)
AS
BEGIN
	SELECT *
	FROM [Order] o
	WHERE o.Id = @Id
END
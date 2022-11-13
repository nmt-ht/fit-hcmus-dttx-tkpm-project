/*
	Created By		:	Tu Nguyen
	Created Date	:	Sep 19, 2022
	Description		:	Book Management - Update data for Book table
*/
CREATE PROCEDURE [dbo].[spr_Inventory_GetAll]
AS
BEGIN
	SELECT *
	FROM Inventory i
	WHERE i.IsDeleted = 0
END
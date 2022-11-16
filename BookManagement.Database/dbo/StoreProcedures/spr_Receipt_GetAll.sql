/*
	Created By		:	Tu Nguyen
	Created Date	:	Nov 16, 2022
	Description		:	Book Management - Insert data for Order Item table
*/
CREATE PROCEDURE [dbo].[spr_Receipt_GetAll]
AS
BEGIN
	SELECT * FROM Receipt WHERE Status = 0 -- unpaid
END
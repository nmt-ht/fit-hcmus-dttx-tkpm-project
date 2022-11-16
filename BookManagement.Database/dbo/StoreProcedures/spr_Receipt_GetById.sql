/*
	Created By		:	Tu Nguyen
	Created Date	:	Nov 16, 2022
	Description		:	Book Management - Insert data for Order Item table
*/
CREATE PROCEDURE [dbo].[spr_Receipt_GetById]
(
	@Id UNIQUEIDENTIFIER = NULL
)
AS
BEGIN
	SELECT * FROM Receipt WHERE Id = @Id
END
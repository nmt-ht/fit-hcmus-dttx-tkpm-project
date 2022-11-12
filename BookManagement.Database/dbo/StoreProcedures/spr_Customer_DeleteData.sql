/*
	Created By		:	Tu Nguyen
	Created Date	:	Sep 19, 2022
	Description		:	Book Management - Delete book
*/
CREATE PROCEDURE [dbo].[spr_Customer_DeleteData]
	@Id UNIQUEIDENTIFIER
AS
BEGIN
	UPDATE C
	SET C.IsActive = 0
	FROM Customer C
	WHERE C.Id = @Id
END

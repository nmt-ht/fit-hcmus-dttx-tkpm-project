/*
	Created By		:	Tu Nguyen
	Created Date	:	Sep 19, 2022
	Description		:	Book Management - Get Book by Id
*/

CREATE PROCEDURE [dbo].[spr_Book_GetBookById]
	@Id UNIQUEIDENTIFIER
AS
BEGIN
	SET NOCOUNT ON  
	SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  

	SELECT * FROM Book WHERE Id = @Id AND IsDeleted = 0

	SET NOCOUNT OFF  
END
/*
	Created By		:	Tu Nguyen
	Created Date	:	Sep 19, 2022
	Description		:	Book Management - Get Books
*/

CREATE PROCEDURE [dbo].[spr_Book_GetAllBooks]
AS
BEGIN
	SET NOCOUNT ON  
	SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  

	SELECT * FROM [Book] WHERE IsDeleted = 0;

	SET NOCOUNT OFF  
END
/*
	Created By		:	Tu Nguyen
	Created Date	:	Sep 19, 2022
	Description		:	Book Management - Get User by Id
*/

CREATE PROCEDURE [dbo].[spr_User_GetUserByUserName]
	@UserName VARCHAR(250)
AS
BEGIN
	SET NOCOUNT ON  
	SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  

	SELECT * FROM [User] WHERE UserName = @UserName AND IsDeleted = 0

	SET NOCOUNT OFF  
END
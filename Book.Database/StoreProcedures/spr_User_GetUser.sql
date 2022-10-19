/*
	Created By		:	Tu Nguyen
	Created Date	:	Sep 19, 2022
	Description		:	Book Management - Get User by Id
*/

CREATE PROCEDURE [dbo].[spr_User_GetUser]
(
	@Id UNIQUEIDENTIFIER = NULL
)
AS
BEGIN
	SET NOCOUNT ON  
	SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  

	SELECT * FROM [User] WHERE Id = @Id

	SET NOCOUNT OFF  
END
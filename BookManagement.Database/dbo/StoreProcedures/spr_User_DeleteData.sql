/*
	Created By		:	Tu Nguyen
	Created Date	:	Sep 19, 2022
	Description		:	Book Management - Delete user
*/
CREATE PROCEDURE [dbo].[spr_User_DeleteData]
	@Id UNIQUEIDENTIFIER
AS
BEGIN
	UPDATE u
	SET u.IsDeleted = 1
	FROM [User] u
	WHERE u.Id = @Id
END

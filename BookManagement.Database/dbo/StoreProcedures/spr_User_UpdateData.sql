/*
	Created By		:	Tu Nguyen
	Created Date	:	Sep 19, 2022
	Description		:	Book Management - Update data for User table
*/

CREATE PROCEDURE [dbo].[spr_User_UpdateData]
	@Id UNIQUEIDENTIFIER, 
	@UserName VARCHAR(250) = NULL,
	@Password VARCHAR(250) = NULL,
	@FirstName VARCHAR(250) = NULL,
	@LastName VARCHAR(250) = NULL,
	@Type TINYINT = 0
AS
BEGIN
	UPDATE u
	SET 
		u.Type = @Type
		, u.ModifiedDate = GETDATE()
		, u.LastName = @LastName
		, u.FirstName = @FirstName
		, u.Password = @Password
		, u.UserName = @UserName
	FROM [User] u
	WHERE u.Id = @Id
END

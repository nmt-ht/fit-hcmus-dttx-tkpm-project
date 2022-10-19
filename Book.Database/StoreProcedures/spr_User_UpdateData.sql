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
	IF(@UserName <> '')
	BEGIN
		UPDATE u
		SET u.UserName = @UserName
		FROM [User] u
		WHERE u.Id = @Id
	END
	IF(@Password <> '')
	BEGIN
		UPDATE u
		SET u.Password = @Password
		FROM [User] u
		WHERE u.Id = @Id
	END
	IF(@FirstName <> '')
	BEGIN
		UPDATE u
		SET u.FirstName = @FirstName
		FROM [User] u
		WHERE u.Id = @Id
	END
	IF(@LastName <> '')
	BEGIN
		UPDATE u
		SET u.LastName = @LastName
		FROM [User] u
		WHERE u.Id = @Id
	END
	
	UPDATE u
	SET u.Type = @Type, u.ModifiedDate = GETDATE()
	FROM [User] u
	WHERE u.Id = @Id
END

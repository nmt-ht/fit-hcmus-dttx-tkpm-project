--USE [Book.Database]
--GO
--IF EXISTS (
--       SELECT *
--       FROM   dbo.sysobjects
--       WHERE  ID = OBJECT_ID(N'[dbo].[spr_User_InsertData]')
--              AND OBJECTPROPERTY(id, N'IsProcedure') = 1
--   )
--    DROP PROCEDURE [dbo].[spr_User_InsertData]
--GO
/*
	Created By		:	Tu Nguyen
	Created Date	:	Sep 19, 2022
	Description		:	Book Management - Insert data for User table
*/
CREATE PROCEDURE [dbo].[spr_User_InsertData]
	@UserName VARCHAR(250),
	@Password VARCHAR(250),
	@FirstName VARCHAR(250),
	@LastName VARCHAR(250),
	@Type TINYINT
AS
BEGIN
	INSERT INTO [User] (Id, UserName, [Password], FirstName, LastName, [Type], IsDeleted, CreatedDate)
	VALUES(NEWID(), @UserName, @Password, @FirstName, @LastName, @Type, 0, GETDATE())
END
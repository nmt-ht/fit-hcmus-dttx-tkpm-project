/*
	Created By		:	Tu Nguyen
	Created Date	:	Sep 19, 2022
	Description		:	Book Management - Insert data for Book table
*/
CREATE PROCEDURE [dbo].[spr_Book_InsertData]
	@Name VARCHAR(250),
	@Author VARCHAR(250),
	@Description VARCHAR(MAX),
	@Quantity VARCHAR(250),
	@TypeOfBook TINYINT,
	@Price MONEY,
	@CreatedBy UNIQUEIDENTIFIER
AS
BEGIN
	INSERT INTO [Book] (Id, [Name], [Author], [Description], Quantity, TypeOfBook, Price, IsDeleted, CreatedDate, CreatedBy)
	VALUES(NEWID(), @Name, @Author, @Description, @Quantity, @TypeOfBook, @Price, 0, GETDATE(), @CreatedBy)
END
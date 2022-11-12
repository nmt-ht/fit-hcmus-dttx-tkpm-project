/*
	Created By		:	Tu Nguyen
	Created Date	:	Sep 19, 2022
	Description		:	Book Management - Insert data for Book table
*/
CREATE PROCEDURE [dbo].[spr_Customer_InsertData]
	@CustomerId UNIQUEIDENTIFIER = NULL,
	@FirstName VARCHAR(250) = '',
	@LastName VARCHAR(250) = '',
	@Gender TINYINT = 0,
	@Birthday DATETIME = NULL,
	@CreatedBy UNIQUEIDENTIFIER = NULL
AS
BEGIN
	INSERT Customer(Id, FirstName, LastName, Gender, Birthday, IsActive, CreatedDate, CreatedBy)
	VALUES(@CustomerID, @FirstName, @LastName, @Gender, @Birthday, 1, GETDATE(), @CreatedBy)
END
/*
	Created By		:	Tu Nguyen
	Created Date	:	Nov 10, 2022
	Description		:	Book Management - Update data for User table
*/

CREATE PROCEDURE [dbo].[spr_Customer_UpdateData]
	@Id UNIQUEIDENTIFIER, 
	@FirstName VARCHAR(250) = NULL,
	@LastName VARCHAR(250) = NULL,
	@Gender TINYINT = 0,
	@Birthday DATETIME = NULL,
	@ModifiedBy UNIQUEIDENTIFIER = NULL
AS
BEGIN
	UPDATE C
	SET C.FirstName = @FirstName,
		c.LastName = @LastName,
		c.Gender = @Gender,
		c.Birthday = @Birthday,
		c.ModifiedBy = @ModifiedBy,
		c.ModifiedDate = GETDATE()
	FROM Customer C
	WHERE C.Id = @Id
END

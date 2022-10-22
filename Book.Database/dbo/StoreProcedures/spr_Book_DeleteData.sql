/*
	Created By		:	Tu Nguyen
	Created Date	:	Sep 19, 2022
	Description		:	Book Management - Delete book
*/
CREATE PROCEDURE [dbo].[spr_Book_DeleteData]
	@Id UNIQUEIDENTIFIER
AS
BEGIN
	UPDATE b
	SET b.IsDeleted = 1
	FROM Book b
	WHERE b.Id = @Id
END

CREATE PROCEDURE [dbo].[spr_Parameter_InsertData]
	@Name NVARCHAR(255),
	@Value Int
AS
BEGIN
	INSERT INTO [Parameter] (Id, [Name], [Value], [IsActive])
	VALUES(NEWID(), @Name, @Value, 1)
END
CREATE PROCEDURE [dbo].[spr_Parameter_InsertData]
	@Name NVARCHAR(255),
	@Value Int,
	@IsActive BIT, 
    @ParameterType TINYINT
AS
BEGIN
	INSERT INTO [Parameter] (Id, [Name], [Value], [IsActive], [ParameterType])
	VALUES(NEWID(), @Name, @Value, @IsActive, @ParameterType)
END
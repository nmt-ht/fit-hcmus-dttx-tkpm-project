CREATE PROCEDURE [dbo].[spr_Parameter_UpdateData]
	@Id UNIQUEIDENTIFIER,
	@Name NVARCHAR(255),
	@Value Int,
	@IsActive BIT, 
    @ParameterType TINYINT
AS
BEGIN
	UPDATE p
	SET  p.[Name] = @Name
		, p.IsActive = @IsActive
		, p.ParameterType = @ParameterType
		, p.Value = @Value
	FROM Parameter p
	WHERE p.Id = @Id
END

CREATE PROCEDURE [dbo].[spr_Parameter_UpdateData]
	@Id UNIQUEIDENTIFIER,
	@Name NVARCHAR(255),
	@Value NVARCHAR(255)
AS
BEGIN
	UPDATE p
	SET  p.[Name] = N'' + @Name + ''
		, p.Value = N'' + @Value + ''
	FROM Parameter p
	WHERE p.Id = @Id
END

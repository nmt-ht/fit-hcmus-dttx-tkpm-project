CREATE PROCEDURE [dbo].[spr_Parameter_DeleteData]
	@Id UNIQUEIDENTIFIER
AS
BEGIN
	UPDATE p
	SET p.IsActive = 0
	FROM Parameter p
	WHERE p.Id = @Id
END
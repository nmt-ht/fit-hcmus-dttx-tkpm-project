﻿CREATE PROCEDURE [dbo].[spr_Parameter_GetParameterById]
	@Id UNIQUEIDENTIFIER
AS
BEGIN
	SET NOCOUNT ON  
	SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  

	SELECT * FROM Parameter WHERE Id = @Id AND IsActive = 1

	SET NOCOUNT OFF  
END

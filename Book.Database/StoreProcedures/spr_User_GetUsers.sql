﻿/*
	Created By		:	Tu Nguyen
	Created Date	:	Sep 19, 2022
	Description		:	Book Management - Get Users
*/

CREATE PROCEDURE [dbo].[spr_User_GetUsers]
AS
BEGIN
	SET NOCOUNT ON  
	SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  

	SELECT * FROM [User]

	SET NOCOUNT OFF  
END
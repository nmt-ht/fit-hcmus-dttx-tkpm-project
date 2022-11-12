/*
	Created By		:	Tu Nguyen
	Created Date	:	Sep 19, 2022
	Description		:	Book Management - Get Books
*/

CREATE PROCEDURE [dbo].[spr_Customer_GetCustomerAddresses]
AS
BEGIN
	SET NOCOUNT ON  
	SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  

	SELECT *
	FROM [CustomerAddress] c

	SET NOCOUNT OFF  
END
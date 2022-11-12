/*
	Created By		:	Tu Nguyen
	Created Date	:	Sep 19, 2022
	Description		:	Book Management - Get Book by Id
*/

CREATE PROCEDURE [dbo].[spr_Customer_GetCustomerById]
	@Id UNIQUEIDENTIFIER
AS
BEGIN
	SET NOCOUNT ON  
	SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  

	SELECT *
	FROM Customer 
	WHERE Id = @Id
	
	SELECT *
	FROM CustomerAddress ca
	WHERE ca.Customer_ID_FK = @Id	


	SET NOCOUNT OFF  
END
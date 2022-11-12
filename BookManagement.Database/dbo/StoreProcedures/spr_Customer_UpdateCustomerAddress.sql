/*
	Created By		:	Tu Nguyen
	Created Date	:	Nov 10, 2022
	Description		:	Book Management - Update data for User table
*/

CREATE PROCEDURE [dbo].[spr_Customer_UpdateCustomerAddress]
	@Id UNIQUEIDENTIFIER = '', 
	@Email VARCHAR(250) = '',
	@Phone VARCHAR(250) = '',
	@Address VARCHAR(250) = '',
	@City VARCHAR(250) = '',
	@Country VARCHAR(250) = '',
	@Customer_ID_FK UNIQUEIDENTIFIER
AS
BEGIN
	UPDATE C
	SET C.Address = @Address,
		c.City = @City,
		c.Country = @Country,
		c.Email = @Email,
		c.Phone = @Phone
	FROM CustomerAddress C
	WHERE C.Id = @Id AND c.Customer_ID_FK = @Customer_ID_FK
END

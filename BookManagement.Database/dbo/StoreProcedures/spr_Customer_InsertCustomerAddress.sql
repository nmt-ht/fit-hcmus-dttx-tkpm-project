/*
	Created By		:	Tu Nguyen
	Created Date	:	Sep 19, 2022
	Description		:	Book Management - Insert data for Book table
*/
CREATE PROCEDURE [dbo].[spr_Customer_InsertCustomerAddress]
(
	@CustomerId UNIQUEIDENTIFIER = '',
	@Email VARCHAR(250) = '',
	@Phone VARCHAR(250) = '',
	@Address NVARCHAR(250) = '',
	@City NVARCHAR(250) = '',
	@Country NVARCHAR(250) = '',
	@AddressType TINYINT = 0
)
AS
BEGIN
	INSERT CustomerAddress(Id, Email, Phone, [Address], City, Country, Type, Customer_ID_FK)
	VALUES(NEWID(), @Email, @Phone, @Address, @City, @Country, @AddressType, @CustomerID)
END
	
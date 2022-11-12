CREATE TABLE [dbo].[CustomerAddress]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY,
	Email VARCHAR(250),
	Phone VARCHAR(250),
	[Address] NVARCHAR(250),
	City VARCHAR(50),
	Country VARCHAR(50),
	[Type] TINYINT,
	Customer_ID_FK UNIQUEIDENTIFIER,
    CONSTRAINT [FK_CustomerAddress_Customer] FOREIGN KEY ([Customer_ID_FK]) REFERENCES [Customer]([Id])
)

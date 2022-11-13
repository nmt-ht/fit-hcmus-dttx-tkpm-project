CREATE TABLE [dbo].[Customer]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY,
	FirstName VARCHAR(250),
	LastName VARCHAR(250),
	Gender TINYINT,
	Birthday DATETIME,
	CreatedBy UNIQUEIDENTIFIER,
	CreatedDate DATETIME,
	ModifiedBy UNIQUEIDENTIFIER,
	ModifiedDate DATETIME,
	Debt MONEY,
	IsActive BIT, 
    CONSTRAINT [FK_Customer_UserCreatedBy] FOREIGN KEY (CreatedBy) REFERENCES [User]([Id]), 
    CONSTRAINT [FK_Customer_UserModifiedBy] FOREIGN KEY (ModifiedBy) REFERENCES [User]([Id])
)

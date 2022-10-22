CREATE TABLE [dbo].[Book]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY,
	[Name] VARCHAR(250),
	[Author] VARCHAR(250),
	[Description] VARCHAR(MAX),
	Quantity INT,
	TypeOfBook TINYINT,
	Price MONEY,
	CreatedDate DATETIME,
	CreatedBy UNIQUEIDENTIFIER,
	ModifiedDate DATETIME,
	ModifiedBy UNIQUEIDENTIFIER,
	IsDeleted BIT, 
    CONSTRAINT [FK_Book_CreatedBy] FOREIGN KEY (CreatedBy) REFERENCES [User]([Id]),
	CONSTRAINT [FK_Book_ModifedBy] FOREIGN KEY (ModifiedBy) REFERENCES [User]([Id])
)

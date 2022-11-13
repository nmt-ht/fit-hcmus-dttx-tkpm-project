CREATE TABLE [dbo].[Inventory]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY,
	AvailableQty INT,
	Book_ID_FK UNIQUEIDENTIFIER,
	CreatedBy UNIQUEIDENTIFIER,
	CreatedDate DATETIME,
	ModifiedBy UNIQUEIDENTIFIER,
	ModifiedDate DATETIME,
	IsDeleted BIT, 
    CONSTRAINT [FK_Inventory_UserCreatedBy] FOREIGN KEY (CreatedBy) REFERENCES [User]([Id]),
	CONSTRAINT [FK_Inventory_UserModifiedBy] FOREIGN KEY (ModifiedBy) REFERENCES [User]([Id]),
	CONSTRAINT [FK_Inventory_Book] FOREIGN KEY (Book_ID_FK) REFERENCES [Book]([Id])
)

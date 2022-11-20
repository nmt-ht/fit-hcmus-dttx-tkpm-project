CREATE TABLE [dbo].[InventorySnapshot]
(
	[sYear] VARCHAR(4) NOT NULL , 
    [sMonth] VARCHAR(2) NOT NULL,
	Book_ID_FK UNIQUEIDENTIFIER NOT NULL,
	[Name] NVARCHAR(250),
	AvailableQty INT,
	TotalQuantity INT,
	StockQty INT,
	UserID VARCHAR(12),
	UserDate SMALLDATETIME,
	PRIMARY KEY([sYear],[sMonth],Book_ID_FK)
)


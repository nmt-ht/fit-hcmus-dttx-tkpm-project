

CREATE PROCEDURE [dbo].[spr_Report_GetStockForBook]
AS
BEGIN
	SET NOCOUNT OFF; 
	Declare @Month varchar(2) = month(GETDATE())
	Declare @Year varchar(4) = Year(GETDATE())
	DELETE FROM  InventorySnapshot WHERE sMonth=@Month and sYear=@Year
	
	INSERT INTO InventorySnapshot(Book_ID_FK,Name, AvailableQty,TotalQuantity,StockQty,sMonth, sYear,UserID,UserDate)
	SELECT i.Book_ID_FK, b.Name, bs.StockQty AvailableQty, ISNULL(WHBook.Quantity,0) - ISNULL(i.AvailableQty,0)
			, ISNULL(bs.StockQty,0) + ISNULL(WHBook.Quantity,0) - ISNULL(i.AvailableQty,0) [StockQty]
			,@Month,@Year,'21850029', GETDATE()
	FROM  Book b
	LEFT JOIN Inventory i ON b.Id=i.Book_ID_FK
	LEFT JOIN (SELECT ID, Quantity FROM Book 
				WHERE year(CreatedDate) = @Year AND month(CreatedDate) = @Month
		) WHBook ON WHBook.Id = i.Book_ID_FK
	LEFT JOIN InventorySnapshot bs ON bs.Book_ID_FK=i.Book_ID_FK AND bs.sYear=Year(DateAdd(month,-1,(bs.UserDate))) 
				AND bs.sMonth=Month(DateAdd(month,-1,(bs.UserDate)))
	SELECT * FROM  InventorySnapshot
END


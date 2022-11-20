using BookManagement.Infrastructure.DataAccess.DbAccess;
using BookManagement.Models;

namespace BookManagement.Infrastructure.DataAccess.Data;

public class BookStockData:IBookStockData
{
    public readonly ISqlDataAccess _db;
    public BookStockData(ISqlDataAccess db)
    {
        _db = db;
    }
    public IEnumerable<BookStock> GetBookStocks()
    {
        return _db.LoadData<BookStock, dynamic>("spr_Inventory_GetAll", new { });
    }
    public BookStock GetBookStockById(Guid id)
    {
        var results = _db.LoadData<BookStock, dynamic>("spr_BookStock_GetBookStockId", new { IndexNo = id });
        return results.FirstOrDefault();
    }
}

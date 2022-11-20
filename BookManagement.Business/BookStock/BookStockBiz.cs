using BookManagement.Infrastructure.DataAccess.Data;
using BookManagement.Models;

namespace BookManagement.Business;

public class BookStockBiz : IBookStockBiz
{
    private readonly IBookStockData _bookStockData;
    public BookStockBiz(IBookStockData bookStockData)
    {
        _bookStockData = bookStockData;
    }

    public IEnumerable<BookStock> GetBookStocks()
    {
        return _bookStockData.GetBookStocks();
    }
}

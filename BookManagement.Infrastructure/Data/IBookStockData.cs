using BookManagement.Models;

namespace BookManagement.Infrastructure.DataAccess.Data;

public interface IBookStockData
{
    BookStock GetBookStockById(Guid indexNo);
    IEnumerable<BookStock> GetBookStocks();
}

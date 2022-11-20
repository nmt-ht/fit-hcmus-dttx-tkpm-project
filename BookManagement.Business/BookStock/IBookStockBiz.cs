using BookManagement.Models;

namespace BookManagement.Business
{
    public interface IBookStockBiz
    {
        IEnumerable<BookStock> GetBookStocks();
    }
}

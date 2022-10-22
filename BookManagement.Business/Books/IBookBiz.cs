using BookManagement.Models;

namespace BookManagement.Business
{
    public interface IBookBiz
    {
        IEnumerable<Book> GetBooks();
    }
}
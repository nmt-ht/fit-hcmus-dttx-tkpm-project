using BookManagement.Models;

namespace BookManagement.Business
{
    public interface IBookBiz
    {
        IEnumerable<Book> GetBooks();
        bool AddNewBook(Book book);
        bool DeleteBook(Guid id);
        bool UpdateBook(Book book);
    }
}
using BookManagement.Models;

namespace BookManagement.Infrastructure.Data
{
    public interface IBookData
    {
        bool DeleteBook(Guid id);
        IEnumerable<Book> GetBookById(Guid id);
        IEnumerable<Book> GetBooks();
        bool InsertBook(Book book);
        bool UpdateBook(Book book);
    }
}
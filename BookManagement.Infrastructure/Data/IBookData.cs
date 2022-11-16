using BookManagement.Models;

namespace BookManagement.Infrastructure.DataAccess.Data;
public interface IBookData
{
    bool DeleteBook(Guid id);
    Book GetBookById(Guid id);
    IEnumerable<Book> GetBooks();
    bool InsertBook(Book book);
    bool UpdateBook(Book book);
}

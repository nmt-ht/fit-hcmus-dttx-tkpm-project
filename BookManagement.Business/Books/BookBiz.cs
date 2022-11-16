using BookManagement.Infrastructure.DataAccess.Data;
using BookManagement.Models;

namespace BookManagement.Business;
public class BookBiz : IBookBiz
{
    private readonly IBookData _bookData;
    public BookBiz(IBookData bookData)
    {
        _bookData = bookData;
    }

    public bool AddNewBook(Book book)
    {
        return _bookData.InsertBook(book);
    }

    public bool DeleteBook(Guid id)
    {
        return _bookData.DeleteBook(id);
    }

    public IEnumerable<Book> GetBooks()
    {
        return _bookData.GetBooks();
    }

    public bool UpdateBook(Book book)
    {
        return _bookData.UpdateBook(book);
    }
}

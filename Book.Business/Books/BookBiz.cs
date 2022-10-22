using BookManagement.Infrastructure.Data;
using BookManagement.Models;

namespace BookManagement.Business;
public class BookBiz : IBookBiz
{
    private readonly IBookData _bookData;
    public BookBiz(IBookData bookData)
    {
        _bookData = bookData;
    }

    public IEnumerable<Book> GetBooks()
    {
        return _bookData.GetBooks();
    }
}

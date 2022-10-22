using BookManagement.Infrastructure.DataAccess.DbAccess;
using BookManagement.Models;

namespace BookManagement.Infrastructure.Data;
public class BookData : IBookData
{
    public readonly ISqlDataAccess _db;
    public BookData(ISqlDataAccess db) => _db = db;
    public IEnumerable<Book> GetBooks()
    {
        return _db.LoadData<Book, dynamic>("spr_User_GetAllBooks", new { });
    }
    public IEnumerable<Book> GetBookById(Guid id)
    {
        return _db.LoadData<Book, dynamic>("spr_User_GetBookById", new { Id = id });
    }
    public bool InsertBook(Book book)
    {
        var result = false;
        try
        {
            _db.SaveData("spr_Book_InsertData",
           new
           {
               book.Name,
               book.Author,
               book.Description,
               book.Quantity,
               book.Price,
               book.TypeOfBook
           });
            result = true;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }

        return result;
    }
    public bool UpdateBook(Book book)
    {
        var result = false;
        try
        {
            _db.SaveData("spr_Book_UpdateData",
           new
           {
               book.Name,
               book.Author,
               book.Description,
               book.Quantity,
               book.Price,
               book.TypeOfBook
           });
            result = true;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }

        return result;
    }
    public bool DeleteBook(Guid id)
    {
        var result = false;
        try
        {
            _db.SaveData("spr_Book_DelteData", new { Id = id });
            result = true;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }

        return result;
    }
}

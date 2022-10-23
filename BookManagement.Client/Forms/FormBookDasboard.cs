using BookManagement.Business;
using BookManagement.Business.Helper;
using BookManagement.Client.Dialog;
using BookManagement.Client.UC;
using BookManagement.Models;
using System.Windows;
using static BookManagement.Client.DataType;

namespace BookManagement.Client.Forms;

public partial class FormBookDasboard : Form
{
    private readonly IBookBiz _bookBiz;
    private ucBooks _ucBooks;
    public User CurrentUser { get; set; }
    public FormBookDasboard(IBookBiz bookBiz)
    {
        InitializeComponent();
        _bookBiz = bookBiz;
    }

    private void FormBookDasboard_Load(object sender, EventArgs e)
    {
        DataBind();
    }

    private void DataBind()
    {
        _ucBooks = new ucBooks();
        _ucBooks.Books = GetBooks();
        double height = SystemParameters.FullPrimaryScreenHeight;
        double width = SystemParameters.FullPrimaryScreenWidth;
        _ucBooks.Size = new System.Drawing.Size((int)width - 200, (int)height);
        _ucBooks.OnReloadBooksDelegate += ucBooks_OnReloadBooksDelegate;
        _ucBooks.OnDeleteItemDelegate += ucBooks_OnDeleteItemDelegate;
        _ucBooks.OnAddBookDelegate += ucBooks_OnAddBookDelegate;
        _ucBooks.OnEditBookDelegate += ucBooks_OnEditBookDelegate;
        _ucBooks.DataBind();
        pnlBookDasboard.Controls.Add(_ucBooks);
    }

    private void ucBooks_OnEditBookDelegate(BookCustomEventArgs bookCustomEvent)
    {
        if(bookCustomEvent is not null && bookCustomEvent.Book is not null)
        {
            bookCustomEvent.Book.ModifiedBy = this.CurrentUser.Id;
            var updated = _bookBiz.UpdateBook(bookCustomEvent.Book);
            if (updated)
            {
                DisplayNotification(eMessageType.Info, "Edit", "Updated data successfully.");
                ReloadData();
            }
        }
    }

    private void ucBooks_OnAddBookDelegate(BookCustomEventArgs bookCustomEvent)
    {
        if(bookCustomEvent is not null && bookCustomEvent.Book is not null)
        {
            bookCustomEvent.Book.CreatedBy = this.CurrentUser.Id;
            var added = _bookBiz.AddNewBook(bookCustomEvent.Book);
            if (added)
            {
                DisplayNotification(eMessageType.Info, "Add", "Added data successfully.");
                ReloadData();
            }
        }
    }

    private void ucBooks_OnDeleteItemDelegate(DeleteItemEventArgs deleteItemEvent)
    {
        var deleted = _bookBiz.DeleteBook(deleteItemEvent.Id);
        if(deleted)
        {
            DisplayNotification(eMessageType.Info, "Delete", "Deleted data successfully.");
            ReloadData();
        }
    }

    private void ucBooks_OnReloadBooksDelegate(ReloadBooksEventArgs reloadBooks)
    {
        ReloadData();
    }

    private void ReloadData()
    {
        _ucBooks.Books = GetBooks();
        _ucBooks.DataBind();
    }

    private IList<Book> GetBooks()
    {
        var books = _bookBiz.GetBooks();
        return books.ToList();
    }

    private void DisplayNotification(eMessageType messageType, string title, string message)
    {
        using (var messageBox = new MessageBoxDialog())
        {
            messageBox.SetParametters(title, message, messageType);
            messageBox.DataBind();
            messageBox.ShowDialog();
        }
    }
}

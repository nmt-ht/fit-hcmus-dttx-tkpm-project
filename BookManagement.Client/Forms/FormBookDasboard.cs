using BookManagement.Business;
using System.Windows;
using BookManagement.Client.UC;
using BookManagement.Models;
using static BookManagement.Business.Helper.DelegateHandler;

namespace BookManagement.Client.Forms;

public partial class FormBookDasboard : Form
{
    private readonly IBookBiz _bookBiz;
    private ucBooks _ucBooks;
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
        _ucBooks.DataBind();
        pnlBookDasboard.Controls.Add(_ucBooks);
    }

    private void ucBooks_OnReloadBooksDelegate(ReloadBooksEventArgs reloadBooks)
    {
        _ucBooks.Books = GetBooks();
        _ucBooks.DataBind();
    }

    private IList<Book> GetBooks()
    {
        var books = _bookBiz.GetBooks();
        return books.ToList();
    }
}

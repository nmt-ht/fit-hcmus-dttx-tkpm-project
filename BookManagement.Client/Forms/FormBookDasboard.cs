using BookManagement.Business;
using System.Windows;
using BookManagement.Client.UC;
using BookManagement.Models;

namespace BookManagement.Client.Forms;

public partial class FormBookDasboard : Form
{
    private readonly IBookBiz _bookBiz;
    public FormBookDasboard(IBookBiz bookBiz)
    {
        InitializeComponent();
        _bookBiz = bookBiz;
    }

    private void FormBookDasboard_Load(object sender, EventArgs e)
    {
        var ucBooks = new ucBooks();
        ucBooks.Books = GetBooks();
        double height = SystemParameters.FullPrimaryScreenHeight;
        double width = SystemParameters.FullPrimaryScreenWidth;
        ucBooks.Size = new System.Drawing.Size((int)width-200, (int)height);
        pnlBookDasboard.Controls.Add(ucBooks);
    }

    private IList<Book> GetBooks()
    {
        var books = _bookBiz.GetBooks();
        return books.ToList();
    }
}

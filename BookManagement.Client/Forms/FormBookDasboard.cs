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
    private readonly IParameterBiz _parameterBiz;
    private ucLayout ucLayout;
    public User CurrentUser { get; set; }
    public FormBookDasboard(IBookBiz bookBiz, IParameterBiz parameterBiz)
    {
        InitializeComponent();
        _bookBiz = bookBiz;
        _parameterBiz = parameterBiz;
    }
    private void FormBookDasboard_Load(object sender, EventArgs e)
    {
        DataBind();
    }
    private void DataBind()
    {
        ucLayout = new ucLayout();
        ucLayout.ParameterBiz = _parameterBiz;
        ucLayout.LayoutType = eLayoutType.Book;
        ucLayout.Books = GetBooks();
        double height = SystemParameters.FullPrimaryScreenHeight;
        double width = SystemParameters.FullPrimaryScreenWidth;
        ucLayout.Size = new System.Drawing.Size((int)width - 200, (int)height);
        ucLayout.OnReloadDataDelegate += ucBooks_OnReloadBooksDelegate;
        ucLayout.OnDeleteItemDelegate += ucBooks_OnDeleteItemDelegate;
        ucLayout.OnAddBookDelegate += ucBooks_OnAddBookDelegate;
        ucLayout.OnEditBookDelegate += ucBooks_OnEditBookDelegate;
        ucLayout.DataBind();
        pnlBookDasboard.Controls.Add(ucLayout);
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
            else { DisplayNotification(eMessageType.Info, "Edit", "Has an error. Please check!"); }
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
            else { DisplayNotification(eMessageType.Info, "Add", "Has an error. Please check!"); }
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
        else { DisplayNotification(eMessageType.Info, "Delete", "Has an error. Please check!"); }
    }
    private void ucBooks_OnReloadBooksDelegate(ReloadDataEventArgs reloadData)
    {
        ReloadData();
    }
    private void ReloadData()
    {
        ucLayout.Books = GetBooks();
        ucLayout.DataBind();
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

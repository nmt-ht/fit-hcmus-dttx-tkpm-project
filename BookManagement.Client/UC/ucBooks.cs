using BookManagement.Business.Helper;
using BookManagement.Client.Dialog;
using BookManagement.Models;
using static BookManagement.Business.Helper.BookDelegateHandler;
using static BookManagement.Business.Helper.DeleteItemDelegateHandler;
using static BookManagement.Business.Helper.ReloadBooksDelegateHandler;
using static BookManagement.Client.DataType;

namespace BookManagement.Client.UC;
public partial class ucBooks : UserControl
{
    public IList<Book> Books { get; set; }
    public Book SelectedBook { get; set; }
    public event ReloadBooksDelegate OnReloadBooksDelegate;
    public event DeleteItemDelegate OnDeleteItemDelegate;
    public event SelectedBookDelegate OnAddBookDelegate;
    public event SelectedBookDelegate OnEditBookDelegate;
    public ucBooks()
    {
        InitializeComponent();
        flowLayoutBooks.AutoScroll = true;
        flowLayoutBooks.AutoSize = true;
        flowLayoutBooks.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        flowLayoutBooks.Location = new Point(0, 10);
        flowLayoutBooks.WrapContents = true;
    }

    public void DataBind()
    {
        if (Books.Any())
        {
            flowLayoutBooks.Controls.Clear();

            foreach (var book in Books)
            {
                ucBookInfo ucBookInfo = new ucBookInfo();
                ucBookInfo.Book = book;
                ucBookInfo.DataBind();
                ucBookInfo.Margin = new Padding(10);
                ucBookInfo.OnSelectedBookDelegate += UcBookInfo_OnSelectedBookDelegate;
                flowLayoutBooks.Controls.Add(ucBookInfo);
            }
        }
    }

    private bool IsSelectedBook { get; set; } = false;
    private void UcBookInfo_OnSelectedBookDelegate(BookCustomEventArgs bookCustomEvent)
    {
        var selectedBooks = flowLayoutBooks.Controls.Cast<ucBookInfo>().Where(uc => uc.IsSelected).ToList();
        IsSelectedBook = selectedBooks.Any() ? true : false;

        if (bookCustomEvent is not null)
        {
            if(bookCustomEvent.IsSelected && SelectedBook is not null && bookCustomEvent.Book != SelectedBook)
            {
                var previouseSelectedBook = selectedBooks.Where(x => x.Book.Name == SelectedBook.Name).FirstOrDefault();
                if (previouseSelectedBook is not null)
                    previouseSelectedBook.IsSelected = false;
            }

            SelectedBook = bookCustomEvent.Book;
        }

        UpdateButtonFunction();
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        using(var addBook = new AddEditBookDialog())
        {
            addBook.SetParametters(new Book(), eAction.Add);
            addBook.DataBind();
            if (addBook.ShowDialog() == DialogResult.OK)
            {
                BookActionCallback(addBook.BookHandler, eAction.Add);
            }
        }
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
        //SelectedUCBookInfo = flowLayoutBooks.Controls.Cast<ucBookInfo>().FirstOrDefault(uc => uc.IsSelected);
        if (SelectedBook is not null)
        {
            using (var editBook = new AddEditBookDialog())
            {
                editBook.SetParametters(SelectedBook, eAction.Edit);
                editBook.DataBind();
                if (editBook.ShowDialog() == DialogResult.OK)
                {
                    BookActionCallback(editBook.BookHandler, eAction.Edit);
                }
            }
        }
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        if (SelectedBook is not null)
        {
            using (var deleteDialog = new DeleteDialog())
            {
                if (deleteDialog.ShowDialog() == DialogResult.OK)
                {
                    BookActionCallback(SelectedBook, eAction.Delete);
                }
            }
        }
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

    private void UpdateButtonFunction()
    {
        if (this.IsSelectedBook)
        {
            btnEdit.Enabled = btnDelete.Enabled = true;
            btnEdit.BackColor = btnDelete.BackColor = Color.Lavender;
            btnAdd.Enabled =  false;
            btnAdd.BackColor = Color.Linen;
        }
        else
        {
            btnEdit.Enabled = btnDelete.Enabled = false;
            btnEdit.BackColor = btnDelete.BackColor = Color.Linen;
            btnAdd.Enabled = true;
            btnAdd.BackColor = Color.Lavender;
        }
    }

    private void btnSearch_Click(object sender, EventArgs e)
    {
        var textSearch = txtSearchText.Text.ToLower();
        if (!string.IsNullOrEmpty(textSearch))
        {
            var searchResults = this.Books.Where(x => x.Name.ToLower().Contains(textSearch)
                                            || x.Author.ToLower().Contains(textSearch)
                                            || x.Description.ToLower().Contains(textSearch)).ToList();
            this.Books = searchResults;
            DataBind();
        }
        else
        {
            DisplayNotification(eMessageType.Warning, "Search", "Please enter book name/author/description to search.");
        }
    }

    private void txtSearchText_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
            btnSearch_Click(sender, e);
    }

    private void btnRefresh_Click(object sender, EventArgs e)
    {
        OnReloadData();
    }

    private void OnReloadData()
    {
        if (OnReloadBooksDelegate != null)
        {
            ReloadBooksEventArgs reloadBooksEventArgs = new ReloadBooksEventArgs(true);
            OnReloadBooksDelegate(reloadBooksEventArgs);
        }
    }

    private void BookActionCallback(Book book, eAction action)
    {
        switch (action)
        {
            case eAction.Add:
                if (OnAddBookDelegate != null)
                {
                    BookCustomEventArgs bookCustomEvent = new BookCustomEventArgs(book);
                    OnAddBookDelegate(bookCustomEvent);
                }
                break;
            case eAction.Edit:
                if (OnEditBookDelegate != null)
                {
                    BookCustomEventArgs bookCustomEvent = new BookCustomEventArgs(book);
                    OnEditBookDelegate(bookCustomEvent);
                }
                break;
            case eAction.Delete:
                if (OnDeleteItemDelegate != null)
                {
                    DeleteItemEventArgs deleteItemEventArgs = new DeleteItemEventArgs(book.Id);
                    OnDeleteItemDelegate(deleteItemEventArgs);
                }
                break;
            default:
                break;
        }
    }
}

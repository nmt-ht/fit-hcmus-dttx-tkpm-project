using BookManagement.Models;
using static BookManagement.Business.Helper.DelegateHandler;
using static BookManagement.Business.Helper.DelegateHandler.BookDelegateHandler;

namespace BookManagement.Client.UC;
public partial class ucBookInfo : UserControl
{
    public Book Book { get; set; }
    public bool IsSelected { get; set; } = false;
    public event SelectedBookDelegate OnSelectedBookDelegate;
    public ucBookInfo()
    {
        InitializeComponent();
    }

    public void DataBind()
    {
        if(Book is not null)
        {
            lblBookName.Text = Book.Name;
            txtAuthor.Text = Book.Author;
            txtDescription.Text = Book.Description?.Substring(0, 75) + "...";
            string price = Book.Price.ToString("c").Replace("$", string.Empty) + " VND";
            txtPrice.Text = price;
        }
    }

    private void ucBookInfo_Click(object sender, EventArgs e)
    {
        IsSelected = !IsSelected;
        NotifyParent(this.Book, IsSelected);
        BorderedSelectItem();
    }

    private void BorderedSelectItem()
    {
       this.BorderStyle = IsSelected ? BorderStyle.Fixed3D : BorderStyle.None;
       //this.BackColor = IsSelected ? System.Drawing.Color.MediumSlateBlue : System.Drawing.Color.Lavender;
    }

    //private void SetSelectedBook(BookCustomEventArgs customEventArgs) => this.Book = customEventArgs.Book;
    public void NotifyParent(Book book, bool isSelected)
    {
        if (OnSelectedBookDelegate != null)
        {
            BookCustomEventArgs bookHandler = new BookCustomEventArgs(book, isSelected);
            OnSelectedBookDelegate(bookHandler);
        }
    }
}

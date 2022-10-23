using BookManagement.Business.Helper;
using BookManagement.Client.Dialog;
using BookManagement.Models;
using static BookManagement.Business.Helper.BookDelegateHandler;

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
            txtDescription.Text = Book.Description?.Length > 100 ? Book.Description?.Substring(0, 100) + "..." : Book.Description;
            string price = Book.Price.ToString("c").Replace("$", string.Empty) + " VND";
            txtPrice.Text = price;
            txtAvailableQty.Text = Book.Quantity < 0 ? "Out of Stock" : Book.Quantity.ToString();
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

    public void NotifyParent(Book book, bool isSelected)
    {
        if (OnSelectedBookDelegate != null)
        {
            BookCustomEventArgs bookHandler = new BookCustomEventArgs(book, isSelected);
            OnSelectedBookDelegate(bookHandler);
        }
    }

    private void btnViewDetail_Click(object sender, EventArgs e)
    {
        using(var bookDetailDialog = new BookDetailDialog())
        {
            bookDetailDialog.Book = this.Book;
            bookDetailDialog.DataBind();
            bookDetailDialog.ShowDialog();
        }
    }
}

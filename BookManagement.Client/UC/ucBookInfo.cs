using BookManagement.Models;

namespace BookManagement.Client.UC;
public partial class ucBookInfo : UserControl
{
    public Book Book { get; set; }
    public bool IsSelected { get; set; } = false;
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
            string price = Book.Price.ToString("c");
            txtPrice.Text = price;
        }
    }

    private void ucBookInfo_Click(object sender, EventArgs e)
    {
        IsSelected = !IsSelected;
        BorderedSelectItem();
    }

    private void BorderedSelectItem()
    {
       this.BorderStyle = IsSelected ? BorderStyle.Fixed3D : BorderStyle.None;
       //this.BackColor = IsSelected ? System.Drawing.Color.MediumSlateBlue : System.Drawing.Color.Lavender;
    }
}

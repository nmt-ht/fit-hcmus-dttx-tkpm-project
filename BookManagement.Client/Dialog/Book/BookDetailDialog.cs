using BookManagement.Business.Helper;
using BookManagement.Models;

namespace BookManagement.Client.Dialog
{
    public partial class BookDetailDialog : Form
    {
        public Book Book { get; set; }
        public BookDetailDialog()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            DialogResult = DialogResult.Cancel;
        }

        public void DataBind()
        {
            txtAuthor.Text = Book.Author;
            txtBookName.Text = Book.Name;
            txtPrice.Text = Book.Price.ToString("c").Replace("$", string.Empty) + " VND";
            txtAvailableQty.Text = Book.AvailableQty < 0 ? "Out of stock" : Book.AvailableQty.ToString();
            txtDescription.Text = Book.Description;
            txtTypeOfBook.Text = Helper.GetEnumDescription(Book.TypeOfBook);
        }
    }
}

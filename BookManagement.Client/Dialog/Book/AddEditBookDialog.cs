using BookManagement.Models;
using static BookManagement.Client.DataType;

namespace BookManagement.Client.Dialog
{
    public partial class AddEditBookDialog : Form
    {
        public Book Book { get; set; }
        public eAction Action { get; set; }
        public AddEditBookDialog()
        {
            InitializeComponent();
        }
        public void SetParametters(Book book, eAction action)
        {
            Book = book;
            Action = action;
        }

        public void DataBind()
        {
            this.picBox.Image = Action == eAction.Add ? Properties.Resources.book_add
                : Properties.Resources.book_edit;

            if (Book is not null && Action == eAction.Edit)
            {
                txtAuthor.Text = Book.Author;
                txtBookName.Text = Book.Name;
                txtPrice.Text = Book.Price.ToString();
                txtQuantity.Text = Book.Quantity.ToString();
                txtDescription.Text = Book.Description;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

using BookManagement.Business.Helper;
using BookManagement.Models;
using System;
using static BookManagement.Client.DataType;
using static BookManagement.Models.DataType;

namespace BookManagement.Client.Dialog
{
    public partial class AddEditBookDialog : Form
    {
        public Book SelectedBook { get; set; }
        public eAction Action { get; set; }
        public Book BookHandler { get; set; }
        public AddEditBookDialog()
        {
            InitializeComponent();
        }
        public void SetParametters(Book book, eAction action)
        {
            SelectedBook = book;
            Action = action;
        }

        public void DataBind()
        {
            LoadTypeOfBooks();
            BindDataToControl();
            this.picBox.Image = Action == eAction.Add ? Properties.Resources.book_add
                : Properties.Resources.book_edit;

            if (SelectedBook is not null && Action == eAction.Edit)
            {
                txtAuthor.Text = SelectedBook.Author;
                txtBookName.Text = SelectedBook.Name;
                txtPrice.Text = SelectedBook.Price.ToString();
                txtQuantity.Text = SelectedBook.Quantity.ToString();
                txtDescription.Text = SelectedBook.Description;
            }
        }

        private void BindDataToControl()
        {
            cboBookTypes.Items.Clear();
            cboBookTypes.DataSource = this.TypeOfBooks;
            cboBookTypes.Text = "Select type of book";
            if(this.Action == eAction.Edit)
            {
                var type = this.TypeOfBooks.Where(x => x == SelectedBook.TypeOfBook).FirstOrDefault();
                cboBookTypes.SelectedItem = type;
                cboBookTypes.SelectedText = Helper.GetEnumDescription(type);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Validation
            //Return result
            GenerateBookHandler();
            DialogResult = DialogResult.OK;
        }

        private IList<eTypeOfBook> TypeOfBooks { get; set; }
        private void LoadTypeOfBooks()
        {
            TypeOfBooks = Enum.GetValues(typeof(eTypeOfBook)).Cast<eTypeOfBook>().ToList();
        }

        private void GenerateBookHandler()
        {
            var newBook = new Book
            {
                Id = Action == eAction.Edit ? SelectedBook.Id : Guid.NewGuid(),
                Name = txtBookName.Text,
                Author = txtAuthor.Text,
                Price = decimal.Parse(txtPrice.Text),
                Quantity = int.Parse(txtQuantity.Text),
                Description = txtDescription.Text,
                TypeOfBook = (eTypeOfBook)cboBookTypes.SelectedValue,
            };

            this.BookHandler = newBook;
        }
    }
}

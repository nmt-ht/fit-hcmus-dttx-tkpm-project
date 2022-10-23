using BookManagement.Business.Helper;
using BookManagement.Models;
using System;
using static BookManagement.Client.DataType;
using static BookManagement.Models.DataType;

namespace BookManagement.Client.Dialog
{
    public partial class AddEditBookDialog : Form
    {
        private Book SelectedBook { get; set; }
        private eAction Action { get; set; }
        private IList<Book> Books { get; set; }
        public Book BookHandler { get; set; }
        public AddEditBookDialog()
        {
            InitializeComponent();
        }
        public void SetParametters(Book book, eAction action, IList<Book>? books)
        {
            SelectedBook = book;
            Action = action;
            this.Books = books;
        }
        public void DataBind()
        {
            LoadTypeOfBooks();
            LoadTypeOfAddBooks();
            BindDataToControl();
            this.picBox.Image = Action == eAction.Add ? Properties.Resources.book_add
                : Properties.Resources.book_edit;

            if (SelectedBook is not null && Action == eAction.Edit)
                BindBookData(SelectedBook);
        }

        private void BindBookData(Book book)
        {
            txtAuthor.Text = book.Author;
            txtBookName.Text = book.Name;
            txtPrice.Text = book.Price.ToString();
            txtQuantity.Text = book.Quantity.ToString();
            txtDescription.Text = book.Description;
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
                cboTypeOfAddBook.Enabled = false;
                cboListOfBooks.Enabled = false;
            }
            else
            {
                cboTypeOfAddBook.Enabled = true;
                cboListOfBooks.Enabled = true;
            }

            cboTypeOfAddBook.Items.Clear();
            cboTypeOfAddBook.DataSource = this.TypeOfAddBooks;
            cboBookTypes.Text = "Select Add Book Type?";
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

        private IList<eTypeOfAddBook> TypeOfAddBooks { get; set; }
        private void LoadTypeOfAddBooks()
        {
            TypeOfAddBooks = Enum.GetValues(typeof(eTypeOfAddBook)).Cast<eTypeOfAddBook>().ToList();
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

        private void cboTypeOfAddBook_SelectedValueChanged(object sender, EventArgs e)
        {
            var typeofAddBook = (eTypeOfAddBook)this.cboTypeOfAddBook.SelectedValue;
            switch (typeofAddBook)
            {
                case eTypeOfAddBook.New:
                    cboListOfBooks.Enabled = false;
                    break;
                case eTypeOfAddBook.Existed:
                    cboListOfBooks.Enabled = true;
                    cboListOfBooks.DataSource = this.Books;
                    cboListOfBooks.DisplayMember = "Name";
                    cboListOfBooks.ValueMember = "Id";
                    break;
            }
        }

        private void cboListOfBooks_SelectedValueChanged(object sender, EventArgs e)
        {
            var book = (Book)cboListOfBooks.SelectedItem;
            if (book is not null)
                BindBookData(book);
        }
    }
}

using BookManagement.Client.Forms;
using BookManagement.Models;

namespace BookManagement.Client.UC;
public partial class ucBooks : UserControl
{
    public IList<Book> Books { get; set; }
    public ucBooks()
    {
        InitializeComponent();
        flowLayoutBooks.AutoScroll = true;
        flowLayoutBooks.AutoSize = true;
        flowLayoutBooks.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        flowLayoutBooks.Location = new System.Drawing.Point(0, 10);
        flowLayoutBooks.WrapContents = true;
    }

    private void ucBooks_Load(object sender, EventArgs e)
    {
        if (Books.Any())
        {
            foreach(var book in Books)
            {
                ucBookInfo ucBookInfo = new ucBookInfo();
                ucBookInfo.Book = book;
                ucBookInfo.DataBind();
                ucBookInfo.Margin = new System.Windows.Forms.Padding(15);
                flowLayoutBooks.Controls.Add(ucBookInfo);
            }
        }
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        using(var addBook = new FormAddEditBook())
        {
            addBook.SetParametters(new Book(), DataType.eAction.Add);
            if(addBook.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
        var selectedUC = flowLayoutBooks.Controls.Cast<ucBookInfo>().FirstOrDefault(uc => uc.IsSelected);
        if (selectedUC != null)
        {
            using (var editBook = new FormAddEditBook())
            {
                editBook.SetParametters(selectedUC.Book, DataType.eAction.Edit);
                editBook.DataBind();
                if (editBook.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }
    }
}

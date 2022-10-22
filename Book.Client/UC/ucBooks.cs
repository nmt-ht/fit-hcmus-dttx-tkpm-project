using BookManagement.Models;
namespace BookManagement.Client.UC;
public partial class ucBooks : UserControl
{
    public IList<Book> MyProperty { get; set; }
    public ucBooks()
    {
        InitializeComponent();
        flowLayoutBooks.AutoScroll = true;
        //flowLayoutBooks.Dock = DockStyle.None;
        flowLayoutBooks.AutoSize = true;
        flowLayoutBooks.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        flowLayoutBooks.Location = new System.Drawing.Point(0, 10);
        flowLayoutBooks.WrapContents = true;
        //int height = (int)SystemParameters.FullPrimaryScreenHeight;
        //int width = (int)SystemParameters.FullPrimaryScreenWidth;
        //flowLayoutBooks.Size = new System.Drawing.Size(100, 100);
    }

    private void ucBooks_Load(object sender, EventArgs e)
    {
        for(int i = 0; i < 50; i++)
        {
            ucBookInfo ucBookInfo = new ucBookInfo();
            ucBookInfo.Margin = new System.Windows.Forms.Padding(15);
            flowLayoutBooks.Controls.Add(ucBookInfo);
        }
    }
}

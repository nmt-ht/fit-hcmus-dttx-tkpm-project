using BookManagement.Client.UC;
using System.Windows;

namespace BookManagement.Client.Forms;
public partial class FormHome : Form
{
    public FormHome()
    {
        InitializeComponent();
    }

    private void FormBookDasboard_Load(object sender, EventArgs e)
    {
        var ucDasboard = new ucHome();
        int height = (int)SystemParameters.FullPrimaryScreenHeight;
        int width = (int)SystemParameters.FullPrimaryScreenWidth;
        ucDasboard.Left = (width - this.ClientSize.Width) / 2;
        ucDasboard.Top = (height - this.ClientSize.Height) / 2;
        pnlDasboard.Controls.Add(ucDasboard);
    }
}

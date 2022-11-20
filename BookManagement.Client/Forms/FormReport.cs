using BookManagement.Business;

namespace BookManagement.Client.Forms;

public partial class FormReport : Form
{
    private IInventorySnapshotBiz _bookStockBiz;
    private bool IsBinded = false;
    public FormReport(IInventorySnapshotBiz bookStockBiz)
    {
        InitializeComponent();
        _bookStockBiz = bookStockBiz;
    }

    private void FormCustomer_Load(object sender, EventArgs e)
    {
        LoadDataForCombobox();
        IsBinded = true;
    }

    private void LoadDataForCombobox()
    {
        cboReport.Items.Clear();
        cboReport.DataSource = GetReports();
    }

    private List<string> GetReports()
    {
        return new List<string>()
        {
            "None",
            "WHStockReport",
            "DebtReport"
        };
    }

    private void cboReport_SelectedIndexChanged(object sender, EventArgs e)
    {
        if(cboReport.SelectedIndex != -1 && cboReport.SelectedIndex != 0 && IsBinded)
        {
            switch (cboReport.SelectedIndex)
            {
                case 1:
                    var formReport = new RptWHStock(_bookStockBiz);
                    formReport.ShowDialog();
                    break;
                case 2:
                    break;
                default:
                    break;
            }
        }
    }
}

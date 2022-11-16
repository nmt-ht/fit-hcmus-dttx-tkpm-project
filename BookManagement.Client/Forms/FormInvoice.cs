using BookManagement.Business;
using BookManagement.Client.UC;
using BookManagement.Models;
using System.Windows;
using static BookManagement.Client.DataType;

namespace BookManagement.Client.Forms;

public partial class FormInvoice : Form
{
    private readonly IReceiptBiz _receiptBiz;
    public User CurrentUser { get; set; }
    private ucLayout ucLayout;
    public FormInvoice(IReceiptBiz receiptBiz)
    {
        InitializeComponent();
        _receiptBiz = receiptBiz;
    }

    private void DataBind()
    {
        ucLayout = new ucLayout();
        ucLayout.LayoutType = eLayoutType.Receipt;
        ucLayout.Receipts = GetReceipts();
        double height = SystemParameters.FullPrimaryScreenHeight;
        double width = SystemParameters.FullPrimaryScreenWidth;
        ucLayout.Size = new System.Drawing.Size((int)width - 200, (int)height);
        ucLayout.DataBind();
        ucLayout.OnPaidReciptDelegate += UcLayout_OnPaidReciptDelegate;
        pnlInvocie.Controls.Add(ucLayout);
    }

    private void UcLayout_OnPaidReciptDelegate(Business.Helper.ReceiptEventArgs receiptEventArgs)
    {
        _receiptBiz.UpdateReceipt(receiptEventArgs.Receipt);
        DataBind();
    }

    private void FormCustomer_Load(object sender, EventArgs e)
    {
        DataBind();
    }

    private List<Receipt> GetReceipts() => _receiptBiz.GetReceipts().ToList();
}

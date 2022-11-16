using BookManagement.Business.Helper;
using BookManagement.Models;
using static BookManagement.Business.Helper.ReceiptDelegateHandler;

namespace BookManagement.Client.UC;
public partial class UcReceiptInfo : UserControl
{
    public Receipt Receipt { get; set; }
    public bool IsSelected { get; set; } = false;
    public event PaidReciptDelegate OnPaidReciptDelegate;
    public UcReceiptInfo()
    {
        InitializeComponent();
    }

    public void DataBind()
    {
        if(Receipt is not null)
        {
            txtOrderID.Text = Receipt.Order is not null ? Receipt.Order.OrderId : string.Empty;
            txtReceiptDate.Text = Receipt.CreatedDate.HasValue ? Receipt.CreatedDate.Value.ToShortDateString() : string.Empty;
            txtStatus.Text = Receipt.Status.ToString();
            txtTotalCustCost.Text = string.Format("{0:#,#.000}", Receipt.TotalCustCost) + " VNĐ";

            lblCustomerName.Text = Receipt.Order.Customer.FullName;
            var address = Receipt.Order.Customer.Addresses.FirstOrDefault();
            if(address is not null)
            {
                txtAddress.Text = address.Address;
                txtPhone.Text = address.Phone;
                txtEmail.Text = address.Email;
            }

            btnSave.Visible = this.Receipt.Status == Models.DataType.eReceiptStatus.Unpaid;
        }
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        if(OnPaidReciptDelegate is not null)
        {
            this.Receipt.Status = Models.DataType.eReceiptStatus.Paid;
            ReceiptEventArgs receiptEventArgs = new ReceiptEventArgs(this.Receipt);
            OnPaidReciptDelegate(receiptEventArgs);
        }
    }
}

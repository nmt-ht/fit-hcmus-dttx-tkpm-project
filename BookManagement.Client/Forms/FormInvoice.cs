using BookManagement.Business;
using BookManagement.Client.UC;
using BookManagement.Models;
using System.Windows;
using static BookManagement.Client.DataType;

namespace BookManagement.Client.Forms;

public partial class FormInvoice : Form
{
    private readonly ICustomerBiz _customerBiz;
    public User CurrentUser { get; set; }
    private ucLayout ucLayout;
    public FormInvoice(ICustomerBiz customerBiz)
    {
        InitializeComponent();
        _customerBiz = customerBiz;
    }

    private void DataBind()
    {
        ucLayout = new ucLayout();
        ucLayout.LayoutType = eLayoutType.Customer;
        double height = SystemParameters.FullPrimaryScreenHeight;
        double width = SystemParameters.FullPrimaryScreenWidth;
        ucLayout.Size = new System.Drawing.Size((int)width - 200, (int)height);
        ucLayout.DataBind();
        pnlInvocie.Controls.Add(ucLayout);
    }

    private void FormCustomer_Load(object sender, EventArgs e)
    {
        DataBind();
    }
}

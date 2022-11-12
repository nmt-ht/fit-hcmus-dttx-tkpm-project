using BookManagement.Business;
using BookManagement.Client.Dialog;
using BookManagement.Client.UC;
using BookManagement.Models;
using System.Windows;
using static BookManagement.Client.DataType;

namespace BookManagement.Client.Forms;

public partial class FormCustomer : Form
{
    private readonly ICustomerBiz _customerBiz;
    public User CurrentUser { get; set; }
    private ucLayout ucLayout;
    public FormCustomer(ICustomerBiz customerBiz)
    {
        InitializeComponent();
        _customerBiz = customerBiz;
    }
    private void FormCustomer_Load(object sender, EventArgs e)
    {
        DataBind();
    }
    private void DataBind()
    {
        ucLayout = new ucLayout();
        ucLayout.Customers = GetCustomers();
        ucLayout.LayoutType = eLayoutType.Customer;
        double height = SystemParameters.FullPrimaryScreenHeight;
        double width = SystemParameters.FullPrimaryScreenWidth;
        ucLayout.Size = new System.Drawing.Size((int)width - 200, (int)height);
        ucLayout.OnAddCustomerDelegate += UcLayout_OnAddCustomerDelegate;
        ucLayout.OnEditCustomerDelegate += UcLayout_OnEditCustomerDelegate;
        ucLayout.OnDeleteItemDelegate += UcLayout_OnDeleteItemDelegate;
        ucLayout.OnReloadDataDelegate += UcLayout_OnReloadDataDelegate;
        ucLayout.DataBind();
        pnlCustomer.Controls.Add(ucLayout);
    }
    private void UcLayout_OnReloadDataDelegate(Business.Helper.ReloadDataEventArgs reload)
    {
        ReloadData();
    }
    private void ReloadData()
    {
        ucLayout.Customers = GetCustomers();
        ucLayout.DataBind();
    }
    private void UcLayout_OnDeleteItemDelegate(Business.Helper.DeleteItemEventArgs deleteItemEvent)
    {
        var deleted = _customerBiz.DeleteCustomer(deleteItemEvent.Id);
        if (deleted)
        {
            DisplayNotification(eMessageType.Info, "Delete", "Deleted data successfully.");
            ReloadData();
        }
    }
    private void UcLayout_OnEditCustomerDelegate(Business.Helper.CustomerCustomEventArgs customerCustomEvent)
    {
        if (customerCustomEvent is not null && customerCustomEvent.Customer is not null)
        {
            customerCustomEvent.Customer.ModifiedBy = this.CurrentUser.Id;
            customerCustomEvent.Customer.ModifiedDate = DateTime.Now;
            var edited = _customerBiz.UpdateCustomer(customerCustomEvent.Customer);
            if (edited)
            {
                DisplayNotification(eMessageType.Info, "Edit", "Updated data successfully.");
                ReloadData();
            }
        }
    }
    private void UcLayout_OnAddCustomerDelegate(Business.Helper.CustomerCustomEventArgs customerCustomEvent)
    {
        if (customerCustomEvent is not null && customerCustomEvent.Customer is not null)
        {
            customerCustomEvent.Customer.CreatedBy = this.CurrentUser.Id;
            var added = _customerBiz.AddNewCustomer(customerCustomEvent.Customer);
            if (added)
            {
                DisplayNotification(eMessageType.Info, "Add", "Added data successfully.");
                ReloadData();
            }
        }
    }
    private IList<Customer> GetCustomers()
    {
        var customers = _customerBiz.GetCustomers();
        return customers.ToList();
    }
    private void DisplayNotification(eMessageType messageType, string title, string message)
    {
        using (var messageBox = new MessageBoxDialog())
        {
            messageBox.SetParametters(title, message, messageType);
            messageBox.DataBind();
            messageBox.ShowDialog();
        }
    }
}

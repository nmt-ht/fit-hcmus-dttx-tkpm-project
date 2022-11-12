using BookManagement.Models;
using static BookManagement.Client.DataType;

namespace BookManagement.Client.Dialog
{
    public partial class AddEditCustomerDialog : Form
    {
        private eAction _action;
        public Customer Customer;
        public AddEditCustomerDialog()
        {
            InitializeComponent();
        }

        public void SetParametters(Customer customer, eAction action)
        {
            _action = action;
            Customer = customer;
        }
        public void DataBind()
        {
            switch (_action)
            {
                case eAction.Add:
                    ucCustomerInfo.DataBind();
                    break;
                case eAction.Edit:
                    ucCustomerInfo.Customer = Customer;
                    ucCustomerInfo.DataBind();
                    break;
                case eAction.Delete:
                    break;
            }
        }
       
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Customer = ucCustomerInfo.GetCustomerObject();
            this.DialogResult = DialogResult.OK;
        }
    }
}

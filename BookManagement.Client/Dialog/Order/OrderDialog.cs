using BookManagement.Business;
using BookManagement.Client.UC;
using BookManagement.Models;
using System.Windows;

namespace BookManagement.Client.Dialog
{
    public partial class OrderDialog : Form
    {
        private readonly ICustomerBiz _customerBiz;
        public OrderDialog(ICustomerBiz customerBiz)
        {
            InitializeComponent();
            flpOrderItems.AutoScroll = true;
            flpOrderItems.AutoSize = true;
            flpOrderItems.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flpOrderItems.WrapContents = true;

            _customerBiz = customerBiz; 
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            DialogResult = DialogResult.Cancel;
        }

        public void SetParameters()
        {

        }

        public void DataBind()
        {
            LoadOrderItems();
            LoadCustomerData();
        }
        
        private void LoadOrderItems()
        {
            var books = ShoppingCart.Books;
            if(books is not null && books.Any())
            {
                flpOrderItems.Controls.Clear();

                for (int i = 0; i < books.Count; i++)
                {
                    var orderItemObject = new OrderItem
                    {
                        Book_ID_FK = books[i].Id,
                        Quantity = 1,
                        Price = books[i].Price,
                        Book = books[i]
                    };

                    var ucOrderItem = new ucOrderItem()
                    {
                        AutoSize = false,
                        Width = (int)SystemParameters.FullPrimaryScreenWidth - 200,
                    };
                    //row.OnSelectedParameterDelegate += ucRow_OnSelected;

                    ucOrderItem.SetParameter(orderItemObject, ++i);
                    ucOrderItem.DataBind();
                    flpOrderItems.Controls.Add(ucOrderItem);
                }
            }
        }

        private void LoadCustomerData()
        {
            var customers = _customerBiz.GetCustomers();
            cboCustomers.DisplayMember = "FullName";
            cboCustomers.ValueMember = "Id"; 
            cboCustomers.DataSource = customers;

            BindCustomerDataToControl(customers.FirstOrDefault());
        }

        private void cboCustomers_SelectedValueChanged(object sender, EventArgs e)
        {
            var customer = (Customer)cboCustomers.SelectedItem;
            if (customer is not null)
                BindCustomerDataToControl(customer);
        }

        private void BindCustomerDataToControl(Customer customer)
        {
            txtFirstName.Text = customer.FirstName;
            txtLastName.Text = customer.LastName;

            var address = customer.Addresses.FirstOrDefault();
            txtAddress.Text = address.Address;
            txtCity.Text = address.City;
            txtCountry.Text = address.Country;
            txtPhone.Text = address.Phone;
            txtEmail.Text = address.Email;
        }

        internal void ResetBackColor()
        {
            foreach (var item in flpOrderItems.Controls.OfType<ucOrderItem>())
            {
                item.BackColorTop = Color.FromArgb(142, 195, 176);
                item.BackColorBottom = Color.FromArgb(141, 114, 225);
            }
        }
    }
}

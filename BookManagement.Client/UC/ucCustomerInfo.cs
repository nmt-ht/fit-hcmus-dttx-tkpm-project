using BookManagement.Business.Helper;
using BookManagement.Models;
using System.Data;
using static BookManagement.Business.Helper.CustomerDelegateHandler;
using static BookManagement.Models.DataType;

namespace BookManagement.Client.UC
{
    public partial class ucCustomerInfo : UserControl
    {
        public Customer Customer { get; set; }
        public bool IsSelected { get; set; } = false;
        public event SelectedCustomerDelegate OnSelectedCustomerDelegate;
        public ucCustomerInfo()
        {
            InitializeComponent();
        }
        public void DataBind()
        {
            LoadGenders();
            if (Customer is not null)
            {
                //Customer info
                txtFirstName.Text = Customer.FirstName;
                txtLastName.Text = Customer.LastName;
                dateBirthday.Value = Customer.Birthday.HasValue ? Customer.Birthday.Value : DateTime.MinValue;
                cboGender.SelectedItem = Customer.Gender;

                //Address info
                if (Customer.Addresses is not null && Customer.Addresses.Any())
                {
                    var primaryAddress = Customer.Addresses.Where(x => x.AddressType == eAddressType.Primary).FirstOrDefault();
                    txtAddress.Text = primaryAddress?.Address;
                    txtCity.Text = primaryAddress?.City;
                    txtCountry.Text = primaryAddress?.Country;
                    txtPhone.Text = primaryAddress?.Phone;
                    txtEmail.Text = primaryAddress?.Email;
                }
            }
        }
        private IList<eGender> Genders { get; set; }
        private void LoadGenders()
        {
            Genders = Enum.GetValues(typeof(eGender)).Cast<eGender>().ToList();
            cboGender.Items.Clear();
            cboGender.DataSource = this.Genders;
        }
        public Customer GetCustomerToCreate()
        {
            var customer = new Customer
            {
                FirstName = txtFirstName.Text,
                LastName = txtFirstName.Text,
                Birthday = dateBirthday.Value,
                Gender = (eGender)cboGender.SelectedValue
            };

            return customer;
        }
        private void ucCustomerInfo_Click(object sender, EventArgs e)
        {
            IsSelected = !IsSelected;
            NotifyParent(this.Customer, IsSelected);
            BorderedSelectItem();
        }
        private void BorderedSelectItem()
        {
            this.BorderStyle = IsSelected ? BorderStyle.Fixed3D : BorderStyle.None;
        }
        public void NotifyParent(Customer customer, bool isSelected)
        {
            if (OnSelectedCustomerDelegate != null)
            {
                CustomerCustomEventArgs customerHandler = new CustomerCustomEventArgs(customer, isSelected);
                OnSelectedCustomerDelegate(customerHandler);
            }
        }
        public Customer GetCustomerObject()
        {
            if (Customer is not null && Customer.Id != Guid.Empty)
            {
                Customer.FirstName = txtFirstName.Text;
                Customer.LastName = txtLastName.Text;
                Customer.Gender = (eGender)cboGender.SelectedItem;
                Customer.Birthday = dateBirthday.Value;

                var customerAddress = Customer.Addresses.FirstOrDefault();
                customerAddress.Address = txtAddress.Text;
                customerAddress.Email = txtEmail.Text;
                customerAddress.City = txtCity.Text;
                customerAddress.Country = txtCountry.Text;
                customerAddress.Phone = txtPhone.Text;

                return Customer;
            }
            else
            {
                var customer = new Customer
                {
                    FirstName = txtFirstName.Text.Trim(),
                    LastName = txtLastName.Text.Trim(),
                    Gender = (eGender)cboGender.SelectedItem,
                    Birthday = dateBirthday.Value,
                };

                var address = new CustomerAddress
                {
                    Email = txtEmail.Text.Trim(),
                    Phone = txtPhone.Text.Trim(),
                    Address = txtAddress.Text.Trim(),
                    City = txtCity.Text.Trim(),
                    Country = txtCountry.Text.Trim()
                };

                customer.Addresses.Add(address);
                return customer;
            }
        }
    }
}

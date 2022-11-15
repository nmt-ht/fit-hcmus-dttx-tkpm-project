using BookManagement.Business;
using BookManagement.Business.Helper;
using BookManagement.Client.UC;
using BookManagement.Models;
using static BookManagement.Client.DataType;

namespace BookManagement.Client.Dialog
{
    public partial class OrderDialog : Form
    {
        private bool IsLoaded = false;
        private readonly ICustomerBiz _customerBiz;
        private readonly IParameterBiz _parameterBiz;
        private readonly IOrderBiz _orderBiz;

        private User CurrentUser { get; set; }
        private Order Order { get; set; }
        private IList<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
        private IList<Parameter> Parameters { get; set; } = new List<Parameter>();
        private const string MINIMUM_CUSTOMER_DEBT = "MINIMUM_CUSTOMER_DEBT";
        private const string MINIMUM_AVALAIBLE_STOCK_QTY_SALE = "MINIMUM_AVALAIBLE_STOCK_QTY_SALE";
        private int MinAvailableToSale { get; set; } = 0;

        public OrderDialog(ICustomerBiz customerBiz, IParameterBiz parameterBiz, IOrderBiz orderBiz)
        {
            InitializeComponent();
            flpOrderItems.AutoScroll = true;
            flpOrderItems.AutoSize = true;
            flpOrderItems.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flpOrderItems.WrapContents = true;

            _customerBiz = customerBiz;
            _parameterBiz = parameterBiz;
            _orderBiz = orderBiz;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            DialogResult = DialogResult.Cancel;
        }

        public void SetParameters(User user)
        {
            CurrentUser = user;
        }

        public void DataBind()
        {
            IsLoaded = false;
            LoadParameters();
            LoadOrderItems();
            LoadCustomerData();
            IsLoaded = true;
        }

        private void LoadParameters()
        {
            Parameters = _parameterBiz.GetParameters().ToList();
            if (Parameters.Any())
            {
                var para = Parameters.FirstOrDefault(x => x.Code == MINIMUM_AVALAIBLE_STOCK_QTY_SALE);
                if(para is not null)
                {
                    MinAvailableToSale = int.Parse(para.Value);
                }
            }
        }
        private void LoadCustomerData()
        {
            var customers = _customerBiz.GetCustomers();
            cboCustomers.DisplayMember = "FullName";
            cboCustomers.ValueMember = "Id";
            cboCustomers.DataSource = customers;

            Order.Customer = customers.FirstOrDefault();
            BindCustomerDataToControl();
        }

        private void LoadOrderItems()
        {
            var books = ShoppingCart.Books;
            if (books is not null && books.Any())
            {
                flpOrderItems.Controls.Clear();
                var indexNo = 1;
                foreach (var book in books)
                {
                    var orderItemObject = new OrderItem
                    {
                        Book_ID_FK = book.Id,
                        Quantity = 1,
                        Price = book.Price,
                        Book = book
                    };

                    OrderItems.Add(orderItemObject);

                    var ucOrderItem = new ucOrderItem()
                    {
                        AutoSize = false
                    };

                    ucOrderItem.OnSelectedOrderItem += UcOrderItem_OnSelectedOrderItem;
                    ucOrderItem.OnUpdateTotalCustomerCost += UcOrderItem_OnUpdateTotalCustomerCost;
                    ucOrderItem.SetParameter(orderItemObject, indexNo, MinAvailableToSale);
                    ucOrderItem.DataBind();
                    flpOrderItems.Controls.Add(ucOrderItem);
                    indexNo++;
                }

                Order = new Order
                {
                    CreatedBy = CurrentUser.Id,
                    OrderDate = DateTime.Now,
                    TotalPrice = TotalCustomerCost(),
                    OrderItems = OrderItems
                };
                
                lblTotalCustomerCost.Text = string.Format("{0:#,#.000}", TotalCustomerCost()) + " VNĐ";
            }
        }

        private void UcOrderItem_OnUpdateTotalCustomerCost(bool value)
        {
            if(value)
                lblTotalCustomerCost.Text = string.Format("{0:#,#.000}", TotalCustomerCost()) + " VNĐ";
        }

        private decimal TotalCustomerCost()
        {
            decimal totalCustomerCost = 0;
            if (OrderItems.Any())
            {
                foreach (var item in OrderItems)
                    totalCustomerCost += item.Quantity * item.Price;
            }
            return totalCustomerCost;
        }

        private void UcOrderItem_OnSelectedOrderItem(OrderItemEventArgs orderItemHandler)
        {
            var selectedOrderItem = orderItemHandler.OrderItem;
            Order.OrderItems.FirstOrDefault(x => x.Book_ID_FK == selectedOrderItem.Book_ID_FK).Quantity = selectedOrderItem.Quantity;
        }

        private void cboCustomers_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!IsLoaded) return;

            var customer = (Customer)cboCustomers.SelectedItem;
            if (customer is not null)
            {
                this.Order.Customer = customer;
                this.Order.Customer_ID_FK = customer.Id;
                BindCustomerDataToControl();
            }
        }

        private void BindCustomerDataToControl()
        {
            if(Order.Customer is not null)
            {
                txtFirstName.Text = Order.Customer.FirstName;
                txtLastName.Text = Order.Customer.LastName;

                var address = Order.Customer.Addresses.FirstOrDefault();
                txtAddress.Text = address.Address;
                txtCity.Text = address.City;
                txtCountry.Text = address.Country;
                txtPhone.Text = address.Phone;
                txtEmail.Text = address.Email;
                ValidateBeforePlaceOrder();
            }
        }

        internal void ResetBackColor()
        {
            foreach (var item in flpOrderItems.Controls.OfType<ucOrderItem>())
            {
                item.BackColorTop = Color.FromArgb(142, 195, 176);
                item.BackColorBottom = Color.FromArgb(141, 114, 225);
            }
        }

        private void ValidateBeforePlaceOrder()
        {
            btnSave.Enabled = false;
            var custDebtValue = this.Parameters.FirstOrDefault(x => x.Code == MINIMUM_CUSTOMER_DEBT).Value;
            if(this.Order.Customer.Debt >= decimal.Parse(custDebtValue))
            {
                DisplayNotification(eMessageType.Warning, "Order Confirmation", $"Customer is debt {this.Order.Customer.Debt}. Cannot place order.");
                return;
            }

            btnSave.Enabled = true;
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            var created = _orderBiz.CreateNewOrder(this.Order);
            if (created)
                DisplayNotification(eMessageType.Info, "Order", "Create an order successfully.");

            //Create Receipt
            DialogResult = DialogResult.OK;
        }
    }
}

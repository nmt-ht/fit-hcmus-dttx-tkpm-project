using BookManagement.Business.Helper;
using BookManagement.Client.Dialog;
using BookManagement.Models;
using static BookManagement.Business.Helper.OrderItemDelegateHandler;
using static BookManagement.Client.DataType;

namespace BookManagement.Client.UC
{
    public partial class ucOrderItem : UserControl
    {
        OrderDialog FormOrderMaster = (OrderDialog)Application.OpenForms["OrderDialog"];
        private OrderItem OrderItem { get; set; }
        private int MinAvailableToSale { get; set; }
        private int IndexNo { get; set; }

        public event SelectedOrderItemDelegate OnSelectedOrderItem;
        public event UpdateTotalCustomerCost OnUpdateTotalCustomerCost;
        public Color BackColorTop
        {
            get { return pnlTitleCustom.GradientTopColor; }
            set { pnlTitleCustom.GradientTopColor = value; }
        }

        public Color BackColorBottom
        {
            get { return pnlTitleCustom.GradientBottomColor; }
            set { pnlTitleCustom.GradientBottomColor = value; }
        }

        public ucOrderItem()
        {
            InitializeComponent();
        }

        public void SetParameter(OrderItem orderItem, int index, int minAvailableToSale)
        {
            OrderItem = orderItem;
            IndexNo = index;
            MinAvailableToSale = minAvailableToSale;
        }

        public void DataBind()
        {
            if(OrderItem is not null)
            {
                lblNo.Text = IndexNo.ToString();
                lblName.Text = OrderItem.Book.Name;
                lblAuthor.Text = OrderItem.Book.Author;
                numQuantity.Value = OrderItem.Quantity;
                lblPrice.Text = string.Format("{0:#,#.000}", OrderItem.Price);
            }
        }

        private void pnlTitleCustom_MouseClick(object sender, MouseEventArgs e)
        {
            NotifyParent(this.OrderItem);
            FormOrderMaster.ResetBackColor();
            this.pnlTitleCustom.GradientTopColor = Color.FromArgb(107, 131, 239);
            this.pnlTitleCustom.GradientBottomColor = Color.FromArgb(195, 121, 225);
        }

        public void NotifyParent(OrderItem orderItem)
        {
            if (OnSelectedOrderItem != null)
            {
                OrderItemEventArgs customerHandler = new OrderItemEventArgs(orderItem);
                OnSelectedOrderItem(customerHandler);
            }
        }

        private void numQuantity_ValueChanged(object sender, EventArgs e)
        {
            if(numQuantity.Value > this.OrderItem.Book.AvailableQty 
                    && this.OrderItem.Book.AvailableQty >= MinAvailableToSale)
            {
                DisplayNotification(eMessageType.Warning, "Order Confirmation", "Ordered Qty cannot be greater than Available Qty for sale.");
                return;
            }

            this.OrderItem.Quantity = int.Parse(numQuantity.Value.ToString());
            lblPrice.Text = string.Format("{0:#,#.000}", this.OrderItem.Quantity * OrderItem.Price);

            if (OnUpdateTotalCustomerCost != null)
                OnUpdateTotalCustomerCost.Invoke(true);
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
}

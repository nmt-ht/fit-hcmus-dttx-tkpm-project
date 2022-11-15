using BookManagement.Client.Dialog;
using BookManagement.Models;

namespace BookManagement.Client.UC
{
    public partial class ucOrderItem : UserControl
    {
        OrderDialog FormOrderMaster = (OrderDialog)Application.OpenForms["OrderDialog"];
        private OrderItem OrderItem { get; set; }
        private int IndexNo { get; set; }
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

        public void SetParameter(OrderItem orderItem, int index)
        {
            OrderItem = orderItem;
            IndexNo = index;
        }

        public void DataBind()
        {
            if(OrderItem is not null)
            {
                lblNo.Text = IndexNo.ToString();
                lblName.Text = OrderItem.Book.Name;
                lblAuthor.Text = OrderItem.Book.Author;
                numQuantity.Value = OrderItem.Quantity;
                lblPrice.Text = OrderItem.Price.ToString();
            }
        }

        private void pnlTitleCustom_MouseClick(object sender, MouseEventArgs e)
        {
            FormOrderMaster.ResetBackColor();
            this.pnlTitleCustom.GradientTopColor = Color.FromArgb(107, 131, 239);
            this.pnlTitleCustom.GradientBottomColor = Color.FromArgb(195, 121, 225);
        }
    }
}

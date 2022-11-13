namespace BookManagement.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        public string? OrderId { get; set; }
        public int TotalQuantity { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime? OrderDate { get; set; }
        public Guid Customer_ID_FK { get; set; }
        public Guid CreatedBy { get; set; }
        public IList<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
        public decimal TotalCustomerCost 
        {
            get
            {
                return TotalQuantity * TotalPrice;
            }
        }
    }
}
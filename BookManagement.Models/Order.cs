namespace BookManagement.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        public string? OrderId { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime? OrderDate { get; set; }
        
        public Guid CreatedBy { get; set; }
        public IList<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
        public Customer Customer { get; set; }

        private Guid customer_ID_FK;
        public Guid Customer_ID_FK
        {
            get
            {
                return Customer is not null ? Customer.Id : customer_ID_FK;
            }
            set
            {
                customer_ID_FK = value;
            }
        }
    }
}
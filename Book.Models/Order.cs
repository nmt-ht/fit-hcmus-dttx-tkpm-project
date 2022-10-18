namespace BookManagement.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        public string? OrderId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public DateTime? OrderDate { get; set; }
        public virtual Customer? Customer { get; set; }
    }
}

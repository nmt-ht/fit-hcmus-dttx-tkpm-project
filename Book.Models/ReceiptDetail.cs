namespace BookManagement.Models
{
    public class ReceiptDetail
    {
        public Guid Id { get; set; }
        public Guid ReceiptId { get; set; }
        public Guid BookId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}

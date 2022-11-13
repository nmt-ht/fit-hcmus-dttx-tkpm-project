namespace BookManagement.Models
{
    public class OrderItem
    {
        public Guid Id { get; set; }
        public Guid Book_ID_FK { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public Guid Order_ID_FK { get; set; }
        public Book Book { get; set; }
    }
}

namespace BookManagement.Models
{
    public class ShoppingCart
    {
        public IList<Book> Books { get; set; } = new List<Book>();
    }
}

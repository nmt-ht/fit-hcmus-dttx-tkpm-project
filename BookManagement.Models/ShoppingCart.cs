namespace BookManagement.Models
{
    public static class ShoppingCart
    {
        public static IList<Book> Books { get; set; } = new List<Book>();
    }
}

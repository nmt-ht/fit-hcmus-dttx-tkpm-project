namespace BookManagement.Models
{
    public class BookStock
    {
        public Guid Book_ID_FK { get; set; }
        public string sYear { get; set; }
        public string sMonth { get; set; }
        public int AvailableQty { get; set; }
        public string Name { get; set; }
        public int TotalQuantity { get; set; }
        public int StockQty { get; set; }
        public string UserID { get; set; }
        public DateTime? UserDate { get; set; }
    }
}

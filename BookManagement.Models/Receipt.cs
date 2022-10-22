using static BookManagement.Models.DataType;

namespace BookManagement.Models
{
    public class Receipt
    {
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public eReceiptStatus ReceiptStatus { get; set; }
        public DateTime? ReceiptDate { get; set; }
        public decimal TotalCustCost { get; set; }
    }
}

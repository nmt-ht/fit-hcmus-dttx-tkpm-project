using static BookManagement.Models.DataType;

namespace BookManagement.Models
{
    public class Receipt
    {
        public Guid Id { get; set; }
        public eReceiptStatus Status { get; set; }
        public DateTime? CreatedDate { get; set; }
        public decimal TotalCustCost { get; set; }
        public Guid Order_ID_FK { get; set; }
        public Order Order { get; set; }
    }
}

using System.ComponentModel.DataAnnotations.Schema;

namespace BookManagement.DTO
{
    [Table("Order")]
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

namespace BookManagement.Models
{
    public class Inventory
    {
        public Guid Id { get; set; }
        public int AvailableQty { get; set; }
        public Guid BookId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? InventoryDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Guid ModifiedBy { get; set; }
        public Guid CreatedBy { get; set; }
    }
}

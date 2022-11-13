namespace BookManagement.Models
{
    public class Inventory
    {
        public Guid Id { get; set; }
        public int AvailableQty { get; set; }
        public Guid Book_ID_FK { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public Guid ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}

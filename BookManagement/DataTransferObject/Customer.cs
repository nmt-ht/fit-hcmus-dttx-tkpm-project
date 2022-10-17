using static BookManagement.DataType;

namespace BookManagement.DTO
{
    public class Customer
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? FullName { get; set; }
        public eGender Gender { get; set; }
        public DateTime? Birthday { get; set; }
        public virtual IList<CustomerAddress>? Addresses { get; set; }
    }
}

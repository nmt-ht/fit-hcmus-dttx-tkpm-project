using static BookManagement.Models.DataType;

namespace BookManagement.Models
{
    public class Customer
    {
        public Guid Id { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }
        public eGender Gender { get; set; }
        public DateTime? Birthday { get; set; }
        public bool? IsActive { get; set; }
        public Guid ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public IList<CustomerAddress>? Addresses { get; set; } = new List<CustomerAddress>();
        public decimal Debt { get; set; }
    }
}

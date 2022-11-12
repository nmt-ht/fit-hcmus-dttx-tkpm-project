using static BookManagement.Models.DataType;

namespace BookManagement.Models
{
    public class CustomerAddress
    {
        public Guid Id { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        public eAddressType AddressType { get; set; }
        public Guid Customer_ID_FK { get; set; }
    }
}

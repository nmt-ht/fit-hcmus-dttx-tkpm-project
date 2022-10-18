
using static BookManagement.Models.DataType;

namespace BookManagement.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public eUserType Type { get; set; }
        public bool IsDeleted { get; set; }

        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }
    }
}

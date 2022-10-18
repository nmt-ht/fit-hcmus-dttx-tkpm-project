using static BookManagement.Models.DataType;

namespace BookManagement.Models
{
    public class Parameter
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Value { get; set; }
        public bool IsActive { get; set; }
        public eParameterType ParameterType { get; set; }
    }
}

using static BookManagement.Models.DataType;

namespace BookManagement.Models;

public class Book
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? Author { get; set; }
    public string? Description { get; set; }
    public int Quantity { get; set; }
    public eTypeOfBook TypeOfBook { get; set; }
    public decimal Price { get; set; }
    public DateTime? CreatedDate { get; set; }
    public DateTime? CreatedBy { get; set; }
    public DateTime? ModifiedDate { get; set; }
    public DateTime? ModifiedBy { get; set; }
    public bool IsDeleted { get; set; }
}

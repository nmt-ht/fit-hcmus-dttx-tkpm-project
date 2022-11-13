using BookManagement.Models;

namespace BookManagement.Infrastructure.DataAccess.Data
{
    public interface IInventoryData
    {
        IEnumerable<Inventory> GetInventories();
        Inventory GetInventoryByBookId(Guid id);
        bool UpdateInventory(Guid inventoryId, Guid bookId, int orderedQty);
    }
}
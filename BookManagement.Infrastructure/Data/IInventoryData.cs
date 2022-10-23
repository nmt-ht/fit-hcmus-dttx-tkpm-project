using BookManagement.Models;

namespace BookManagement.Infrastructure.DataAccess.Data
{
    public interface IInventoryData
    {
        bool DeleteInventory(Guid id);
        IEnumerable<Inventory> GetInventories();
        Inventory GetInventoryByBookId(Guid id);
        bool InsertInventory(Inventory inventory);
        bool UpdateInventory(Inventory inventory);
    }
}
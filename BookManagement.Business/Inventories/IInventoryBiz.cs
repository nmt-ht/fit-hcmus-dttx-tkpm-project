using BookManagement.Models;

namespace BookManagement.Business
{
    public interface IInventoryBiz
    {
        bool DeleteInventory(Guid id);
        IEnumerable<Inventory> GetInventories();
        Inventory GetInventoryByBookId(Guid bookId);
        bool InsertInventory(Inventory inventory);
        bool UpdateInventory(Inventory inventory);
    }
}
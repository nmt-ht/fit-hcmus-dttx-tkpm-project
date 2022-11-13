using BookManagement.Models;

namespace BookManagement.Business
{
    public interface IInventoryBiz
    {
        IEnumerable<Inventory> GetInventories();
        Inventory GetInventoryByBookId(Guid bookId);
        bool UpdateInventory(Guid inventoryId, Guid bookId, int orderedQty);
    }
}
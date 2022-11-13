using BookManagement.Infrastructure.DataAccess.Data;
using BookManagement.Models;

namespace BookManagement.Business;
public class InventoryBiz : IInventoryBiz
{
    private readonly IInventoryData _inventoryData;
    public InventoryBiz(IInventoryData inventoryData)
    {
        _inventoryData = inventoryData;
    }
    public bool UpdateInventory(Guid inventoryId, Guid bookId, int orderedQty)
    {
        return _inventoryData.UpdateInventory(inventoryId, bookId, orderedQty);
    }
    public IEnumerable<Inventory> GetInventories()
    {
        return _inventoryData.GetInventories();
    }
    public Inventory GetInventoryByBookId(Guid bookId)
    {
        return _inventoryData.GetInventoryByBookId(bookId);
    }
}

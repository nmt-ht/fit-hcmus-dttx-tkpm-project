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
    public bool InsertInventory(Inventory inventory)
    {
        return _inventoryData.InsertInventory(inventory);
    }
    public bool UpdateInventory(Inventory inventory)
    {
        return _inventoryData.InsertInventory(inventory);
    }
    public bool DeleteInventory(Guid id)
    {
        return _inventoryData.DeleteInventory(id);
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

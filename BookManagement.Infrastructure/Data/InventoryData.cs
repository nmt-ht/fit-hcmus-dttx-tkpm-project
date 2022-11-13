using BookManagement.Infrastructure.DataAccess.DbAccess;
using BookManagement.Models;

namespace BookManagement.Infrastructure.DataAccess.Data;
public class InventoryData : IInventoryData
{
    public readonly ISqlDataAccess _db;
    public InventoryData(ISqlDataAccess db)
    {
        _db = db;
    }
    public IEnumerable<Inventory> GetInventories()
    {
        return _db.LoadData<Inventory, dynamic>("spr_Inventory_GetAll", new { });
    }
    public Inventory GetInventoryByBookId(Guid id)
    {
        var results = _db.LoadData<Inventory, dynamic>("spr_Inventory_GetInventoryByBookId", new { BookId = id });
        return results.FirstOrDefault();
    }
   
    public bool UpdateInventory(Guid inventoryId, Guid bookId, int orderedQty)
    {
        var result = false;
        try
        {
            _db.SaveData("spr_Inventory_UpdateData",
            new
            {
                inventoryId,
                bookId,
                orderedQty
            });
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
        return result;
    }
}

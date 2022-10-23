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
        var results = _db.LoadData<Inventory, dynamic>("spr_Inventory_GetByBookId", new { BookId = id });
        return results.FirstOrDefault();
    }
    public bool InsertInventory(Inventory inventory)
    {
        var result = false;
        try
        {
            _db.SaveData("spr_Inventory_InsertData",
           new
           {
               inventory.BookId,
               inventory.AvailableQty
           });
            result = true;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }

        return result;
    }
    public bool UpdateInventory(Inventory inventory)
    {
        var result = false;
        try
        {
            _db.SaveData("spr_Inventory_UpdateData",
            new
            {
                inventory.Id,
                inventory.BookId,
                inventory.AvailableQty
            });
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
        return result;
    }
    public bool DeleteInventory(Guid id)
    {
        var result = false;
        try
        {
            _db.SaveData("spr_Inventory_DeleteData", new { Id = id });
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
        return result;
    }
}

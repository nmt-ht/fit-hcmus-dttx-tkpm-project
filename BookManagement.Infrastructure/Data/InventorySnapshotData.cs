using BookManagement.Infrastructure.DataAccess.DbAccess;
using BookManagement.Models;

namespace BookManagement.Infrastructure.DataAccess.Data;

public class InventorySnapshotData:IInventorySnapshotData
{
    public readonly ISqlDataAccess _db;
    public InventorySnapshotData(ISqlDataAccess db)
    {
        _db = db;
    }
    public IEnumerable<InventorySnapshot> GetInventorySnapshots()
    {
        return _db.LoadData<InventorySnapshot, dynamic>("spr_Report_GetStockForBook", new { });
    }
    public InventorySnapshot GetInventorySnapshotById(Guid id)
    {
        var results = _db.LoadData<InventorySnapshot, dynamic>("spr_BookStock_GetBookStockId", new { IndexNo = id });
        return results.FirstOrDefault();
    }
}

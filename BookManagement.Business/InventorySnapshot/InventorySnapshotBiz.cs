using BookManagement.Infrastructure.DataAccess.Data;
using BookManagement.Models;

namespace BookManagement.Business;
public class InventorySnapshotBiz : IInventorySnapshotBiz
{
    private readonly IInventorySnapshotData _iventorySnapshotData;
    public InventorySnapshotBiz(IInventorySnapshotData iventorySnapshotData)
    {
        _iventorySnapshotData = iventorySnapshotData;
    }

    public IEnumerable<InventorySnapshot> GetInventorySnapshots()
    {
        return _iventorySnapshotData.GetInventorySnapshots();
    }
}

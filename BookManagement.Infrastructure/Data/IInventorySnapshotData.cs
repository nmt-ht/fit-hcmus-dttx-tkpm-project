using BookManagement.Models;

namespace BookManagement.Infrastructure.DataAccess.Data;

public interface IInventorySnapshotData
{
    InventorySnapshot GetInventorySnapshotById(Guid indexNo);
    IEnumerable<InventorySnapshot> GetInventorySnapshots();
}

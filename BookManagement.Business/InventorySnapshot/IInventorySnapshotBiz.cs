using BookManagement.Models;

namespace BookManagement.Business
{
    public interface IInventorySnapshotBiz
    {
        IEnumerable<InventorySnapshot> GetInventorySnapshots();
    }
}

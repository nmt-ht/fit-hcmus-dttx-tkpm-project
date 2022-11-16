using BookManagement.Models;

namespace BookManagement.Business
{
    public interface IReceiptBiz
    {
        bool CreateReceipt(Receipt receipt);
        Receipt GetReceiptById(Guid id);
        IEnumerable<Receipt> GetReceipts();
        bool UpdateReceipt(Receipt receipt);
    }
}
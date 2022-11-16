using BookManagement.Models;

namespace BookManagement.Infrastructure.DataAccess.Data
{
    public interface IReceiptData
    {
        bool CreateReceipt(Receipt receipt);
        Receipt GetReceiptById(Guid id);
        IEnumerable<Receipt> GetReceipts();
        bool UpdateReceipt(Receipt receipt);
    }
}
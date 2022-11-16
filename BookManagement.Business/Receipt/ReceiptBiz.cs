using BookManagement.Infrastructure.DataAccess.Data;
using BookManagement.Models;

namespace BookManagement.Business;
public class ReceiptBiz : IReceiptBiz
{
    private readonly IReceiptData _receiptData;
    public ReceiptBiz(IReceiptData receiptData)
    {
        _receiptData = receiptData;
    }

    public bool CreateReceipt(Receipt receipt)
    {
        return _receiptData.CreateReceipt(receipt);
    }

    public bool UpdateReceipt(Receipt receipt)
    {
        return _receiptData.UpdateReceipt(receipt);
    }

    public IEnumerable<Receipt> GetReceipts()
    {
        return _receiptData.GetReceipts();
    }

    public Receipt GetReceiptById(Guid id)
    {
        return _receiptData.GetReceiptById(id);
    }
}
using BookManagement.Infrastructure.DataAccess.Data;
using BookManagement.Models;

namespace BookManagement.Business;
public class ReceiptBiz : IReceiptBiz
{
    private readonly IReceiptData _receiptData;
    private readonly IOrderBiz _orderBiz;
    private readonly ICustomerBiz _customerBiz;
    public ReceiptBiz(IReceiptData receiptData, IOrderBiz orderBiz, ICustomerBiz customerBiz)
    {
        _receiptData = receiptData;
        _orderBiz = orderBiz;
        _customerBiz = customerBiz;
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
        var receipts =  _receiptData.GetReceipts();
        if(receipts is not null && receipts.Any())
        {
            foreach(var receipt in receipts)
            {
                var order = _orderBiz.GetOrderById(receipt.Order_ID_FK);
                receipt.Order = order;
            }
        }

        return receipts.ToList();
    }

    public Receipt GetReceiptById(Guid id)
    {
        return _receiptData.GetReceiptById(id);
    }
}
using BookManagement.Infrastructure.DataAccess.DbAccess;
using BookManagement.Models;

namespace BookManagement.Infrastructure.DataAccess.Data;
public class ReceiptData : IReceiptData
{
    public readonly ISqlDataAccess _db;
    public ReceiptData(ISqlDataAccess db)
    {
        _db = db;
    }
    public IEnumerable<Receipt> GetReceipts()
    {
        return _db.LoadData<Receipt, dynamic>("spr_Receipt_GetAll", new { });
    }
    public Receipt GetReceiptById(Guid id)
    {
        var results = _db.LoadData<Receipt, dynamic>("spr_Receipt_GetById", new { Id = id });
        return results.FirstOrDefault();
    }
    public bool CreateReceipt(Receipt receipt)
    {
        var result = false;
        try
        {
            _db.SaveData("spr_Receipt_Create",
           new
           {
               receipt.Order_ID_FK,
               receipt.TotalCustCost,
               receipt.Status
           });
            result = true;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }

        return result;
    }
    public bool UpdateReceipt(Receipt receipt)
    {
        var result = false;
        try
        {
            _db.SaveData("spr_Receipt_Update",
            new
            {
                receipt.Id,
                receipt.Order_ID_FK,
                receipt.Status
            });
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
        return result;
    }
}

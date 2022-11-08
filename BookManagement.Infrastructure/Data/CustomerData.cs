using BookManagement.Infrastructure.DataAccess.DbAccess;
using BookManagement.Models;

namespace BookManagement.Infrastructure.Data;
public class CustomerData : ICustomerData
{
    public readonly ISqlDataAccess _db;
    public CustomerData(ISqlDataAccess db)
    {
        _db = db;
    }
    public IEnumerable<Customer> GetCustomers()
    {
        return _db.LoadData<Customer, dynamic>("spr_User_GetAllUsers", new { });
    }
    public Customer GetCustomerById(Guid id)
    {
        var results = _db.LoadData<Customer, dynamic>("spr_User_GetUserById", new { Id = id });
        return results.FirstOrDefault();
    }
    public bool InsertCustomer(Customer customer)
    {
        var result = false;
        try
        {
            _db.SaveData("spr_User_InsertData",
           new
           {

           });
            result = true;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }

        return result;
    }
    public bool UpdateCustomer(Customer customer)
    {
        var result = false;
        try
        {
            _db.SaveData("spr_User_UpdateData",
            new
            {

            });
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
        return result;
    }
    public bool DeleteCustomer(Guid id)
    {
        var result = false;
        try
        {
            _db.SaveData("spr_User_DeleteData", new { Id = id });
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
        return result;
    }
}

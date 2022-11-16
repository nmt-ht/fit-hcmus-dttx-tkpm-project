using BookManagement.Infrastructure.DataAccess.DbAccess;
using BookManagement.Models;

namespace BookManagement.Infrastructure.DataAccess.Data;
public class CustomerData : ICustomerData
{
    public readonly ISqlDataAccess _db;
    public CustomerData(ISqlDataAccess db)
    {
        _db = db;
    }
    public IEnumerable<Customer> GetCustomers()
    {
        var customers = _db.LoadData<Customer, dynamic>("spr_Customer_GetCustomers", new { });
        var customerAddresss = _db.LoadData<CustomerAddress, dynamic>("spr_Customer_GetCustomerAddresses", new { });

        foreach (var customer in customers)
        {
            foreach (var address in customerAddresss)
            {
                if (address.Customer_ID_FK == customer.Id)
                    customer.Addresses.Add(address);
            }
        }
        return customers;
    }
    public Customer GetCustomerById(Guid id)
    {
        var results = _db.LoadData<Customer, dynamic>("spr_Customer_GetCustomerById", new { Id = id });
        return results.FirstOrDefault();
    }
    public bool InsertCustomer(Customer customer)
    {
        var result = false;
        try
        {
            Guid customerId = Guid.NewGuid();
            _db.SaveData("spr_Customer_InsertData",
               new
               {
                   customerId,
                   customer.FirstName,
                   customer.LastName,
                   customer.Gender,
                   customer.Birthday,
                   customer.CreatedBy
               });

            if (customer.Addresses != null && customer.Addresses.Any())
            {
                customer.Addresses.ToList().ForEach(address =>
                {
                    _db.SaveData("spr_Customer_InsertCustomerAddress",
                      new
                      {
                          customerId,
                          address.Email,
                          address.Phone,
                          address.Address,
                          address.City,
                          address.Country,
                          address.AddressType
                      });
                });
            }
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
            _db.SaveData("spr_Customer_UpdateData",
            new
            {
                customer.Id,
                customer.FirstName,
                customer.LastName,
                customer.Gender,
                customer.Birthday,
                customer.ModifiedBy
            });

            if (customer.Addresses != null && customer.Addresses.Any())
            {
                customer.Addresses.ToList().ForEach(address =>
                {
                    _db.SaveData("spr_Customer_UpdateCustomerAddress",
                      new
                      {
                          address.Id,
                          address.Email,
                          address.Phone,
                          address.Address,
                          address.City,
                          address.Country,
                          Customer_ID_FK = customer.Id
                      });
                });
            }

            result = true;
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
            _db.SaveData("spr_Customer_DeleteData", new { Id = id });
            result = true;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
        return result;
    }
}

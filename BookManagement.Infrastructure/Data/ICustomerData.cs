using BookManagement.Models;

namespace BookManagement.Infrastructure.DataAccess.Data;
public interface ICustomerData
{
    bool DeleteCustomer(Guid id);
    Customer GetCustomerById(Guid id);
    IEnumerable<Customer> GetCustomers();
    bool InsertCustomer(Customer customer);
    bool UpdateCustomer(Customer customer);
}

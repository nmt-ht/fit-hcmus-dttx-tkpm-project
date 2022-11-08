using BookManagement.Models;

namespace BookManagement.Business
{
    public interface ICustomerBiz
    {
        bool AddNewCustomer(Customer customer);
        bool DeleteCustomer(Guid id);
        IEnumerable<Customer> GetCustomers();
        bool UpdateCustomer(Customer customer);
    }
}
using BookManagement.Models;

namespace BookManagement.Business
{
    public interface ICustomerBiz
    {
        bool AddNewCustomer(Customer customer);
        bool DeleteCustomer(Guid id);
        IEnumerable<Customer> GetCustomers();
        Customer GetCustomerById(Guid id);
        bool UpdateCustomer(Customer customer);
    }
}
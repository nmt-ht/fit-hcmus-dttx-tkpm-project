﻿using BookManagement.Infrastructure.DataAccess.Data;
using BookManagement.Models;

namespace BookManagement.Business;
public class CustomerBiz : ICustomerBiz
{
    private readonly ICustomerData _customerData;
    public CustomerBiz(ICustomerData customerData)
    {
        _customerData = customerData;
    }

    public bool AddNewCustomer(Customer customer)
    {
        return _customerData.InsertCustomer(customer);
    }

    public bool DeleteCustomer(Guid id)
    {
        return _customerData.DeleteCustomer(id);
    }

    public Customer GetCustomerById(Guid id)
    {
        return _customerData.GetCustomerById(id);
    }

    public IEnumerable<Customer> GetCustomers()
    {
        return _customerData.GetCustomers();
    }

    public bool UpdateCustomer(Customer customer)
    {
        return _customerData.UpdateCustomer(customer);
    }
}

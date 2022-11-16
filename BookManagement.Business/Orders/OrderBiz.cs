using BookManagement.Infrastructure.DataAccess.Data;
using BookManagement.Models;

namespace BookManagement.Business;
public class OrderBiz : IOrderBiz
{
    private readonly IOrderData _orderData;
    private readonly ICustomerBiz _customerBiz;
    public OrderBiz(IOrderData orderData, ICustomerBiz customerBiz)
    {
        _orderData = orderData;
        _customerBiz = customerBiz;
    }

    public bool CreateNewOrder(Order order)
    {
        return _orderData.CreateNewOrder(order);
    }

    public Order GetOrderById(Guid id)
    {
        var order =  _orderData.GetOrder(id);
        if(order is not null)
        {
            var customer = _customerBiz.GetCustomerById(order.Customer_ID_FK);
            order.Customer = customer;
        }

        return order;
    }
}

using BookManagement.Infrastructure.Data;
using BookManagement.Models;

namespace BookManagement.Business;
public class OrderBiz : IOrderBiz
{
    private readonly IOrderData _orderData;
    public OrderBiz(IOrderData orderData)
    {
        _orderData = orderData;
    }

    public bool CreateNewOrder(Order order)
    {
        return _orderData.CreateNewOrder(order);
    }
}

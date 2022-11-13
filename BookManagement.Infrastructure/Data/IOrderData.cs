using BookManagement.Models;

namespace BookManagement.Infrastructure.Data;
public interface IOrderData
{
    bool CreateNewOrder(Order order);
    Order GetOrder(Guid id);
    IEnumerable<Order> GetOrders();
}

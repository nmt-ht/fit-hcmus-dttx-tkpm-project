using BookManagement.Models;

namespace BookManagement.Infrastructure.DataAccess.Data;
public interface IOrderData
{
    bool CreateNewOrder(Order order);
    Order GetOrder(Guid id);
    IEnumerable<Order> GetOrders();
}

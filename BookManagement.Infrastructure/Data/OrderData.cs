using BookManagement.Infrastructure.DataAccess.DbAccess;
using BookManagement.Models;

namespace BookManagement.Infrastructure.Data;
public class OrderData : IOrderData
{
    private IBookData _bookData;
    public readonly ISqlDataAccess _db;
    public OrderData(ISqlDataAccess db, IBookData bookData)
    {
        _db = db;
        _bookData = bookData;
    }
    public bool CreateNewOrder(Order order)
    {
        var result = false;
        try
        {
            Guid orderId = Guid.NewGuid();
            order.Id = orderId;

            _db.SaveData("spr_Order_InsertData",
               new
               {
                   order.Id,
                   order.Customer_ID_FK,
                   order.CreatedBy,
                   order.TotalPrice,
               });

            if (order.OrderItems.Any())
            {
                order.OrderItems.ToList().ForEach(item =>
                {
                    item.Order_ID_FK = order.Id;

                    _db.SaveData("spr_Order_InsertOrderItem",
                      new
                      {
                          item.Price,
                          item.Quantity,
                          item.Book_ID_FK,
                          item.Order_ID_FK
                      });
                });
            }

            _db.SaveData("spr_Order_UpdateCreateOrder", new { });
            result = true;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }

        return result;
    }
    public Order GetOrder(Guid id)
    {
        var order = _db.LoadData<Order, dynamic>("spr_Order_GetOrderById", new { Id = id }).FirstOrDefault();

        if (order is not null)
        {
            var orderItems = _db.LoadData<OrderItem, dynamic>("spr_Order_GetOrderItemById", new { Id = id });
            if (orderItems is not null && orderItems.Any())
            {
                orderItems.ToList().ForEach(item =>
                {
                    var book = _bookData.GetBookById(item.Book_ID_FK);
                    item.Book = book;
                    order.OrderItems.Add(item);
                });
            }
        }

        return order;
    }

    public IEnumerable<Order> GetOrders()
    {
        var orders = _db.LoadData<Order, dynamic>("spr_Order_GetOrders", new { });

        if (orders is not null && orders.Any())
        {
            var orderItems = _db.LoadData<OrderItem, dynamic>("spr_Order_GetOrderItems", new { });
            orders.ToList().ForEach(order =>
            {
                if (orderItems is not null && orderItems.Any())
                {
                    orderItems.ToList().ForEach(item =>
                    {
                        if (order.Id == item.Order_ID_FK)
                        {
                            var book = _bookData.GetBookById(item.Book_ID_FK);
                            item.Book = book;
                            order.OrderItems.Add(item);
                        }
                    });
                }
            });
        }

        return orders;
    }
}

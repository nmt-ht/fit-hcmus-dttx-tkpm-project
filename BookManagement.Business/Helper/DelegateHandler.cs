using BookManagement.Models;
using System.Data;

namespace BookManagement.Business.Helper;

public static class UserDelegateHandler
{
    public delegate void UserDelegate(UserCustomEventArgs userCustomEventArgs);
}

public static class BookDelegateHandler
{
    public delegate void SelectedBookDelegate(BookCustomEventArgs bookCustomEventArgs);
}

public static class CustomerDelegateHandler
{
    public delegate void SelectedCustomerDelegate(CustomerCustomEventArgs customerCustomEventArgs);
}

public static class ParameterDelegateHandler
{
    public delegate void SelectedParameterDelegate(ParameterEventArgs parameterEventArgs);
}

public static class ReceiptDelegateHandler
{
    public delegate void PaidReciptDelegate(ReceiptEventArgs receiptEventArgs);
}

public static class OrderItemDelegateHandler
{
    public delegate void SelectedOrderItemDelegate(OrderItemEventArgs orderItemEventArgs);
    public delegate void UpdateTotalCustomerCost(bool value);
}

public static class ReloadDataDelegateHandler
{
    public delegate void ReloadDataDelegate(ReloadDataEventArgs reload);
}

public static class DeleteItemDelegateHandler
{
    public delegate void DeleteItemDelegate(DeleteItemEventArgs deleteItemEvent);
}

public delegate void SearchHandler(SearchEventArgs e);

public class UserCustomEventArgs : EventArgs
{
    public UserCustomEventArgs(User user) => User = user;
    public User User { get; set; }
}

public static class OrderDelegateHandler
{
    public delegate void OrderBookDelegate(OrderCustomEventArgs orderCustomEventArgs);
}

public delegate void AddItemDelegate(EventArgs eventArgs);
public delegate void EditItemDelegate(EventArgs eventArgs);
public delegate void SelectedRowDelegate(string[] items);

public class BookCustomEventArgs : EventArgs
{
    public BookCustomEventArgs(Book book, bool isSelected = false)
    {
        this.Book = book;
        this.IsSelected = isSelected;
    }
    public Book Book { get; set; }
    public bool IsSelected { get; set; }
}

public class CustomerCustomEventArgs : EventArgs
{
    public CustomerCustomEventArgs(Customer customer, bool isSelected = false)
    {
        this.Customer = customer;
        this.IsSelected = isSelected;
    }
    public Customer Customer { get; set; }
    public bool IsSelected { get; set; }
}

public class ReloadDataEventArgs : EventArgs
{
    public ReloadDataEventArgs(bool reload)
    {
        Reload = reload;
    }
    public bool Reload { get; set; }
}

public class DeleteItemEventArgs : EventArgs
{
    public DeleteItemEventArgs(Guid id) => this.Id = id;
    public Guid Id { get; set; }
}

public class ParameterEventArgs : EventArgs
{
    public ParameterEventArgs(Parameter parameter)
    {
        this.Parameter = parameter;
    }
    public Parameter Parameter { get; set; }
}

public class OrderCustomEventArgs : EventArgs
{
    public OrderCustomEventArgs(bool reloadItem) => ReloadItem = reloadItem;
    public bool ReloadItem { get; set; }
}

public class SearchEventArgs : EventArgs
{
    public string SearchText { get; set; }

    public SearchEventArgs(string searchText)
    {
        SearchText = searchText;
    }
}

public class OrderItemEventArgs: EventArgs
{
    public OrderItemEventArgs(OrderItem orderItem)
    {
        this.OrderItem = orderItem;
    }
    public OrderItem OrderItem { get; set; }
}

public class ReceiptEventArgs: EventArgs
{
    public ReceiptEventArgs(Receipt receipt)
    {
        this.Receipt = receipt;
    }
    public Receipt Receipt { get; set; }
}
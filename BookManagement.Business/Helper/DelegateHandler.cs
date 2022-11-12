using BookManagement.Models;

namespace BookManagement.Business.Helper;

public static class UserDelegateHandler
{
    public delegate void UserDelegate(UserCustomEventArgs loginHandler);
}

public static class BookDelegateHandler
{
    public delegate void SelectedBookDelegate(BookCustomEventArgs loginHandler);
}

public static class CustomerDelegateHandler
{
    public delegate void SelectedCustomerDelegate(CustomerCustomEventArgs loginHandler);
}

public static class ReloadDataDelegateHandler
{
    public delegate void ReloadDataDelegate(ReloadDataEventArgs reload);
}

public static class DeleteItemDelegateHandler
{
    public delegate void DeleteItemDelegate(DeleteItemEventArgs deleteItemEvent);
}

public class UserCustomEventArgs : EventArgs
{
    public UserCustomEventArgs(User user) => User = user;
    public User User { get; set; }
}

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
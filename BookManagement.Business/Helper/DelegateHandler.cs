using BookManagement.Models;

namespace BookManagement.Business.Helper;

public static class DelegateHandler
{
    public static class UserDelegateHandler
    {
        public delegate void UserDelegate(UserCustomEventArgs loginHandler);
    }

    public static class BookDelegateHandler
    {
        public delegate void SelectedBookDelegate(BookCustomEventArgs loginHandler);
    }

    public static class ReloadBooksDelegateHandler
    {
        public delegate void ReloadBooksDelegate(ReloadBooksEventArgs reloadBooks);
    }

    public class UserCustomEventArgs : EventArgs
    {
        public UserCustomEventArgs(User user) => User = user;
        public User User { get; set; }
    }

    public class BookCustomEventArgs : EventArgs
    {
        public BookCustomEventArgs(Book book, bool isSelected)
        {
            this.Book = book;
            this.IsSelected = isSelected;
        }
        public Book Book { get; set; }
        public bool IsSelected { get; set; }
    }

    public class ReloadBooksEventArgs: EventArgs
    {
        public ReloadBooksEventArgs(bool reload)
        {
            Reload = reload;
        }
        public bool Reload { get; set; }
    }
}


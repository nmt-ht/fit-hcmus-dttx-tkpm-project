using BookManagement.Models;

namespace Book.Business.Helper
{
    public static class UserDelegateHandler
    {
        public delegate void UserDelegate(CustomEventArgs loginHandler);
    }

    public class CustomEventArgs : EventArgs
    {
        public CustomEventArgs(User user)
        {
            User = user;
        }

        public User User { get; set; }
    }
}

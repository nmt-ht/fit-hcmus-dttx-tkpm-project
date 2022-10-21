using BookManagement.Models;

namespace BookManagement.Infrastructure.DataAccess.Data
{
    public interface IUserData
    {
        User? GetUser(Guid id);
        User? GetUser(string userName);
        IEnumerable<User> GetUsers();
        void InsertUser(User user);
        void UpdateUser(User user);
        void DeleteUser(Guid id);
    }
}
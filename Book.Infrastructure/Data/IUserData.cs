using BookManagement.Models;

namespace BookManagement.Infrastructure.DataAccess.Data;
public interface IUserData
{
    User GetUserById(Guid id);
    User GetUserByUserName(string userName);
    IEnumerable<User> GetUsers();
    bool InsertUser(User user);
    bool UpdateUser(User user);
    bool DeleteUser(Guid id);
}
using BookManagement.Models;

namespace BookManagement.Business;
public interface IUserBiz
{
    IEnumerable<User> GetUsers();
    User GetUserByUserName(string userName);
    bool AddUser(User user);
    bool CheckExistingUser(string userName);
}
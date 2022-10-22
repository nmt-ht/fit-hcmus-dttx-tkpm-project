using BookManagement.Models;

namespace BookManagement.Business;
public interface IUserBiz
{
    User GetUserByUserName(string userName);
    bool AddUser(User user);
    bool CheckExistingUser(string userName);
}
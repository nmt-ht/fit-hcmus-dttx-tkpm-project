using BookManagement.Infrastructure.DataAccess.Data;
using BookManagement.Models;

namespace Book.Business;
public class UserBiz : IUserBiz
{
    private readonly IUserData _userData;
    public UserBiz(IUserData userData)
    {
        _userData = userData;
    }

    public User GetUserByUserName(string userName)
    {
        return _userData.GetUserByUserName(userName);
    }
}
using BookManagement.Infrastructure.DataAccess.Data;

namespace Book.Business;
public class UserBiz : IUserBiz
{
    private readonly IUserData _userData;
    public UserBiz(IUserData userData)
    {
        _userData = userData;
    }

    public bool CheckPassword4Login(string userName, string passWord)
    {
        var users = _userData.GetUsers();
        if (users is not null)
        {
            var userLogin = users.FirstOrDefault(x => x.UserName == userName);
            return userLogin is not null && userLogin.Password == passWord;
        }

        return false;
    }
}
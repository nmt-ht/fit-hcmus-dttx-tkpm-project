using BookManagement.Models;

namespace Book.Business
{
    public interface IUserBiz
    {
        User GetUserByUserName(string userName);
    }
}
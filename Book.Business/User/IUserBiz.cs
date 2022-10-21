namespace Book.Business
{
    public interface IUserBiz
    {
        bool CheckPassword4Login(string userName, string passWord);
    }
}
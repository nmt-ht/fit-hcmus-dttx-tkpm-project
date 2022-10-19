using Book.Infrastructure.DataAccess.Data;

namespace BookManagement.Business
{
    public class UserBiz
    {
        private readonly IUserData _userData;
        public UserBiz(IUserData userData)
        {
            _userData = userData;
        }

        public async Task<bool> CheckPassword4Login(string userName, string passWord)
        {
            var users = await _userData.GetUsers();
            if(users is not null)
            {
                var userLogin = users.FirstOrDefault(x => x.UserName == userName);
                return userLogin is not null && userLogin.Password == passWord;
            }

            return false;
        }
    }
}

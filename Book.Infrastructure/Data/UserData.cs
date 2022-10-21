using BookManagement.Infrastructure.DataAccess.DbAccess;
using BookManagement.Models;

namespace BookManagement.Infrastructure.DataAccess.Data
{
    public class UserData : IUserData
    {
        public readonly ISqlDataAccess _db;
        public UserData(ISqlDataAccess db)
        {
            _db = db;
        }
        public IEnumerable<User> GetUsers()
        {
            return _db.LoadData<User, dynamic>("spr_User_GetAllUsers", new { });
        }
        public User GetUserById(Guid id)
        {
            var results = _db.LoadData<User, dynamic>("spr_User_GetUserById", new { Id = id });
            return results.FirstOrDefault();
        }
        public void InsertUser(User user) => _db.SaveData("spr_User_InsertData",
                new
                {
                    user.FirstName,
                    user.LastName,
                    user.UserName,
                    user.Password,
                    user.Type
                });
        public void UpdateUser(User user) => _db.SaveData("spr_User_UpdateData",
                new
                {
                    user.FirstName,
                    user.LastName,
                    user.UserName,
                    user.Password,
                    user.Type
                });
        public void DeleteUser(Guid id) => _db.SaveData("spr_User_DeleteData", new { Id = id });
        public User GetUserByUserName(string userName)
        {
            var results = _db.LoadData<User, dynamic>("spr_User_GetUserByUserName", new { UserName = userName });
            return results.FirstOrDefault();
        }
    }
}

using Book.Infrastructure.DataAccess.DbAccess;
using BookManagement.Models;

namespace Book.Infrastructure.DataAccess.Data
{
    public class UserData : IUserData
    {
        public readonly ISqlDataAccess _db;
        public UserData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<IEnumerable<User>> GetUsers() => _db.LoadData<User, dynamic>("spr_User_GetUsers", new { });

        public async Task<User?> GetUser(Guid id)
        {
            var results = await _db.LoadData<User, dynamic>("spr_User_GetUsers", new { Id = id });
            return results.FirstOrDefault();
        }

        public Task InsertUser(User user) => _db.SaveData("spr_User_InsertData",
                new
                {
                    user.FirstName,
                    user.LastName,
                    user.UserName,
                    user.Password,
                    user.Type
                });
        public Task UpdateUser(User user) => _db.SaveData("spr_User_UpdateData",
                new
                {
                    user.FirstName,
                    user.LastName,
                    user.UserName,
                    user.Password,
                    user.Type
                });
        public Task DeleteUser(Guid id) => _db.SaveData("spr_User_DeleteData", new { Id = id });
    }
}

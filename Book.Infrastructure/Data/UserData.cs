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

        public Task<IEnumerable<User>> GetUsers() => _db.LoadData<User, dynamic>("", new { });

        public async Task<User?> GetUser(Guid id)
        {
            var results = await _db.LoadData<User, dynamic>("", new { Id = id });
            return results.FirstOrDefault();
        }

        public Task InsertUser(User user) => _db.SaveData("", new { user.FirstName, user.LastName });
        public Task UpdateUser(User user) => _db.SaveData("", new { user });
        public Task DeleteUser(Guid id) => _db.SaveData("", new { Id = id });
    }
}

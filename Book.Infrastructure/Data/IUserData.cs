using BookManagement.Models;

namespace Book.Infrastructure.DataAccess.Data
{
    public interface IUserData
    {
        Task DeleteUser(Guid id);
        Task<User?> GetUser(Guid id);
        Task<User?> GetUser(string userName);
        Task<IEnumerable<User>> GetUsers();
        Task InsertUser(User user);
        Task UpdateUser(User user);
    }
}
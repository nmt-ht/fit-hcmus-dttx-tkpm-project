namespace BookManagement.Infrastructure.DataAccess.DbAccess
{
    public interface ISqlDataAccess
    {
        IEnumerable<T> LoadData<T, U>(string storedProcedure, U parameters, string connectionId = "Default");
        void SaveData<T>(string storedProcedure, T parameters, string connectionId = "Default");
    }
}
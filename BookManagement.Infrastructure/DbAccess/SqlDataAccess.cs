using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace BookManagement.Infrastructure.DataAccess.DbAccess
{
    public class SqlDataAccess : ISqlDataAccess
    {
        private readonly IConfiguration _configuration;
        public SqlDataAccess(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IEnumerable<T> LoadData<T, U>(string storedProcedure, U parameters, string connectionId = "Default")
        {
            try
            {
                IDbConnection connection = new SqlConnection(_configuration.GetConnectionString(connectionId));
                var result = connection.Query<T>(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void SaveData<T>(string storedProcedure, T parameters, string connectionId = "Default")
        {
            using IDbConnection connection = new SqlConnection(_configuration.GetConnectionString(connectionId));
            connection.Execute(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
        }
    }
}

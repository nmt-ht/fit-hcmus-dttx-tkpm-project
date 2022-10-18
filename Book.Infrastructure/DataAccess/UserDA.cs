using System.Data;
using Dapper;
using Microsoft.Data.SqlClient;

namespace EnterpriseLibrary.DataAccess
{
    public class UserDA
    {
        private string connectionString = string.Empty;
        public DataTable Login(string username, string password)
        {
            try
            {
                string strSql = "SELECT * FROM users WHERE username = @username AND password = @password";
                using (var connection = new SqlConnection(connectionString))
                {

                }
               
                DataTable dt = new DataTable();
                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

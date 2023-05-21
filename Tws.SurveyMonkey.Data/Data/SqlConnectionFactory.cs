using System.Data.SqlClient;
using System.Data;

namespace Tws.SurveyMonkey.Data
{
    public interface ISqlConnectionFactory
    {
        IDbConnection CreateConnection();
    }
    public class SqlConnectionFactory : ISqlConnectionFactory
    {
        private readonly string _connectionString;

        public SqlConnectionFactory(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IDbConnection CreateConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
using System.Data;
using Microsoft.Data.SqlClient;

namespace SMA.Infrastructure.Data.Factory
{
    public class ConnectionFactory : IConnectionFactory
    {
        private readonly string ConnectionString;

        public ConnectionFactory(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public IDbConnection GetConnection => new SqlConnection(ConnectionString);
    }
}
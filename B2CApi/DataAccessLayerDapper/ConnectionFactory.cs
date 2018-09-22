using System.Data.SqlClient;

namespace DataAccessLayerDapper
{
    public class ConnectionFactory : IConnectionFactory
    {
        public SqlConnection Create(string connectionString)
        {
            var connection = new SqlConnection(connectionString);
            connection.Open();
            return connection;
        }
    }
}

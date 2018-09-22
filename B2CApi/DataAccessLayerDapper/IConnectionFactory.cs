using System.Data.SqlClient;

namespace DataAccessLayerDapper
{
    /// <summary>
    /// Фабрика SqlConnection
    /// </summary>
    public interface IConnectionFactory
    {
        SqlConnection Create(string connectionString);
    }
}

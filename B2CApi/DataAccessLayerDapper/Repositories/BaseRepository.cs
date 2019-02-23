using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DataAccessLayerDapper.Repositories
{
    internal class BaseRepository
    {
        public SqlConnection Connection;

        public BaseRepository(SqlConnection connection)
        {
            Connection = connection;
        }
    }
}

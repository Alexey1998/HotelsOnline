using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DataAccessLayerDapper.Repositories
{
    public class BaseRepository
    {
        public SqlConnection Connection;

        public BaseRepository(SqlConnection connection)
        {
            Connection = connection;
        }
    }
}

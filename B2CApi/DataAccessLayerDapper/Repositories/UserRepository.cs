using System.Data.SqlClient;
using DataAccessLayerDapper.Domain;
using DataAccessLayerDapper.Repositories.Interfaces;

namespace DataAccessLayerDapper.Repositories
{
    public class UserRepository: BaseRepository, IUserRepository
    {
        public UserRepository(SqlConnection connection) : base(connection)
        {
        }

        public User GetUserById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}

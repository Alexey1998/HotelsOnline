using DataAccessLayerDapper.Domain;

namespace DataAccessLayerDapper.Repositories.Interfaces
{
    internal interface IUserRepository
    {
        /// <summary>
        /// Получить пользователя по Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        User GetUserById(int id);
    }
}

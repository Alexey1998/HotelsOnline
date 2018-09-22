using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayerDapper.Domain;
using DataAccessLayerDapper.Repositories;
using DataAccessLayerDapper.Services.Interfaces;

namespace DataAccessLayerDapper.Services
{
    public class ClientService : IClientService
    {
        //TODO пока что он пуст
        private static readonly string ConnectionString = string.Empty;

        public IConnectionFactory Factory = new ConnectionFactory();

        public User GetUserById(int id)
        {
            using (var connecton = Factory.Create(ConnectionString))
            {
                var userRepository = new UserRepository(connecton);
                return userRepository.GetUserById(id);
            }
        }
    }
}

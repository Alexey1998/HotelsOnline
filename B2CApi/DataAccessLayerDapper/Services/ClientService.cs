﻿using System;
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
        private static readonly string ConnectionString = String.Empty;

        public IConnectionFactory Factory = new ConnectionFactory();

        public User GetUserById(int id)
        {
            using (var connection = Factory.Create(ConnectionString))
            {
                var userRepository = new UserRepository(connection);
                return userRepository.GetUserById(id);
            }
        }
    }
}

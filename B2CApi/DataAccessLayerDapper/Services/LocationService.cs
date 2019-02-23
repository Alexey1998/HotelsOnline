using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayerDapper.Domain;
using DataAccessLayerDapper.Repositories;
using DataAccessLayerDapper.Services.Interfaces;

namespace DataAccessLayerDapper.Services
{
    public class LocationService : ILocationService
    {
        private static readonly string ConnectionString = System.Configuration.ConfigurationManager.
            ConnectionStrings["Locations"].ConnectionString;

        public IConnectionFactory Factory = new ConnectionFactory();
        public IList<City> GetCitiesByName(string name)
        {
            using (var connection = Factory.Create(ConnectionString))
            {
                var repository = new CityRepository(connection);
                return repository.GetCitiesByName(name);
            }
        }
    }
}

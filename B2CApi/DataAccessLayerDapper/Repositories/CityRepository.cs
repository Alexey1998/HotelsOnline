using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Dapper;
using DataAccessLayerDapper.Domain;
using DataAccessLayerDapper.Repositories.Interfaces;

namespace DataAccessLayerDapper.Repositories
{
    internal class CityRepository : BaseRepository, ICityRepository
    {
        public CityRepository(SqlConnection connection) : base(connection)
        {
        }


        public IList<City> GetCitiesByName(string name)
        {
            var query = $"select * from _cities where title_ru like '%{name}%'";
            var cities = Connection.Query<City>(query).ToList();

            return cities;
        }
    }
}

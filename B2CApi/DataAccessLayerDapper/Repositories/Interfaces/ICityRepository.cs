using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayerDapper.Domain;

namespace DataAccessLayerDapper.Repositories.Interfaces
{
    internal interface ICityRepository
    {
        IList<City> GetCitiesByName(string name);
    }
}

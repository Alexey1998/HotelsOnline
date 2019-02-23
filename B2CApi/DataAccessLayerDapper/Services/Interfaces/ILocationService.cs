using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayerDapper.Domain;

namespace DataAccessLayerDapper.Services.Interfaces
{
    internal interface ILocationService
    {
        IList<City> GetCitiesByName(string name);
    }
}

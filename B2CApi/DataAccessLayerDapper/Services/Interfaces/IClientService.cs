using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayerDapper.Domain;

namespace DataAccessLayerDapper.Services.Interfaces
{
    public interface IClientService
    {
        User GetUserById(int id);
    }
}

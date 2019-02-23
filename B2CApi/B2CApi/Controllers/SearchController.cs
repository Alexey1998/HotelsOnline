using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using B2CApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace B2CApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Search")]
    public class SearchController : Controller
    {
        [HttpGet("{cityName}")]
        public IList<Locations> CityGetByName(string cityName)
        {
            var searchList = new List<Locations>();


            return searchList;
        }
    }
}

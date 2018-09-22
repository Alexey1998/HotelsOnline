using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace B2CApi.Controllers
{
    [Produces("application/json")]
    [Route("api/User")]
    public class UserController : Controller
    {
        [HttpGet("{name}")]
        public string UserExists(string name)
        {
            return name != string.Empty ? "User exist" : "User is not exist";
        }
    }
}
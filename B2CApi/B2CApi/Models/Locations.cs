using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace B2CApi.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Locations
    {
        [JsonProperty]
        public IList<Location> LocationsList { get; set; }

        public Locations()
        {
            LocationsList = new List<Location>();
        }
    }
}

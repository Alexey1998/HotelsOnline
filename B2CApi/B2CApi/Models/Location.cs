using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace B2CApi.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Location
    {
        [JsonProperty]
        public string Name { get; set; }
    }
}

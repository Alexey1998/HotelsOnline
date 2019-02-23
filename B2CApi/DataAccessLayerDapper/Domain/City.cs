using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayerDapper.Domain
{
    public class City
    {
        public int CityId { get; set; }

        public int CountyId { get; set; }

        public int? RegionId { get; set; }

        public string TitleRu { get; set; }
    }
}

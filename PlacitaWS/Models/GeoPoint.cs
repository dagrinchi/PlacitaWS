using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlacitaWS.Models
{
    public class GeoPoint
    {
        public int Id { get; set; }

        public double latitude { get; set; }

        public double longitude { get; set; }

        public DateTime Created { get; set; }

        public DateTime Updated { get; set; }
    }
}
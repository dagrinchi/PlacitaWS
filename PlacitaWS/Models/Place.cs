using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlacitaWS.Models
{
    public class Place
    {
        public int Id { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }
    }
}
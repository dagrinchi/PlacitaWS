using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlacitaWS.Models
{
    public class Price
    {
        public int Id { get; set; }

        public Product Product { get; set; }

        public Unit Unit { get; set; }

        public double PricePerUnit { get; set; }

        public GeoPoint GeoPoint { get; set; }

        public DateTime Created { get; set; }

        public DateTime Updated { get; set; }
    }
}
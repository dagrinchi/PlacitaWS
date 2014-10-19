using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlacitaWS.Models
{
    public class Price
    {
        public Price()
        {
            Created = DateTime.Now;
            Updated = DateTime.Now;
        }

        public int Id { get; set; }

        public Product Product { get; set; }

        public Unit Unit { get; set; }

        public double PriceMaxPerUnit { get; set; }

        public double PriceMinPerUnit { get; set; }

        public double PriceAvgPerUnit { get; set; }

        public string Location { get; set; }

        public DateTime Created { get; set; }

        public DateTime Updated { get; set; }
    }
}
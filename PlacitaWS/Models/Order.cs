using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlacitaWS.Models
{
    public class Order
    {

        public int Id { get; set; }

        public Stock Stock { get; set; } 

        public double Qty { get; set; }

        public double PricePerUnit { get; set; }

        public DateTime Created { get; set; }

        public DateTime Updated { get; set; }
    }
}
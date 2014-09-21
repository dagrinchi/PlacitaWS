﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlacitaWS.Models
{

    public class Stock
    {
    
        public int Id { get; set; }

        public Product Product { get; set; }

        public Unit Unit { get; set; }

        public double Qty { get; set; }

        public double PricePerUnit { get; set; }

        public DateTime ExpiresAt { get; set; }

        public GeoPoint GeoPoint { get; set; }

        public User User { get; set; }
     
        public DateTime Created { get; set; }

        public DateTime Updated { get; set; }
    }
}
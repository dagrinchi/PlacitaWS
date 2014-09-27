using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlacitaWS.Models
{
    public class OrderStatus
    {
        public OrderStatus()
        {
            Created = DateTime.Now;
            Updated = DateTime.Now;
        }

        public int Id { get; set; }

        public string Status { get; set; }

        public bool Farmer { get; set; }

        public bool Buyer { get; set; }

        public string Color { get; set; }

        public DateTime Created { get; set; }

        public DateTime Updated { get; set; }

    }
}
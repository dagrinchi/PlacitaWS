using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PlacitaWS.Models
{
    public class Order
    {

        public Order()
        {
            Created = DateTime.Now;
            Updated = DateTime.Now;
        }

        public int Id { get; set; }

        public Stock Stock { get; set; }

        public string FullName { get; set; }

        public string Phone { get; set; }

        public double Qty { get; set; }

        public GeoPoint GeoPoint { get; set; }

        public ApplicationUser User { get; set; }

        public DateTime Created { get; set; }

        public DateTime Updated { get; set; }
    }

    public class OrderBinding {
        [Required]
        public int StockId { get; set; }
        
        [Required]
        public string FullName { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        
        [Required]
        public double Qty { get; set; }

        [Required]
        public GeoPoint GeoPoint { get; set; }
    }
}
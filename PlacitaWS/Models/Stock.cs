using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PlacitaWS.Models
{

    public class Stock
    {
        public Stock()
        {
            Created = DateTime.Now;
            Updated = DateTime.Now;
        }
    
        public int Id { get; set; }

        public Product Product { get; set; }

        public Unit Unit { get; set; }

        public double Qty { get; set; }

        public double PricePerUnit { get; set; }

        public DateTime ExpiresAt { get; set; }

        public GeoPoint GeoPoint { get; set; }

        public ApplicationUser User { get; set; }
     
        public DateTime Created { get; set; }

        public DateTime Updated { get; set; }
    }

    public class StockBinding
    {
        [Required]
        public int ProductId { get; set; }
        [Required]
        public int UnitId { get; set; }
        [Required]
        public double Qty { get; set; }
        [Required]
        public double PricePerUnit { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime ExpiresAt { get; set; }
        [Required]
        public GeoPointBinding GeoPoint { get; set; }
    }
}
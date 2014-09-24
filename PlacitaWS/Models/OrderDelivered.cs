using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PlacitaWS.Models
{
    public class OrderDelivered
    {

        public OrderDelivered()
        {
            Created = DateTime.Now;
            Updated = DateTime.Now;
        }

        public int Id { get; set; }

        public OrderStatus OrderStatus { get; set; }

        public Order Order { get; set; }

        public string Comment { get; set; }

        public ApplicationUser User { get; set; }

        public DateTime Created { get; set; }

        public DateTime Updated { get; set; }
    
    }

    public class OrderDeliveredBinding
    {
        [Required]
        public int OrderStatusId { get; set; }

        [Required]
        public int OrderId { get; set; }

        [Required]
        public string Comment { get; set; }

    }
}
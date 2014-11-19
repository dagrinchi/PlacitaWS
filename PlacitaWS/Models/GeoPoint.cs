using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace PlacitaWS.Models
{
    [DataContract]
    public class GeoPoint
    {
        public GeoPoint()
        {
            Created = DateTime.Now;
            Updated = DateTime.Now;
        }
        public int Id { get; set; }

        [DataMember]
        public double Latitude { get; set; }

        [DataMember]
        public double Longitude { get; set; }

        [DataMember]
        public string Address { get; set; }

        [DataMember]
        public string Town { get; set; }

        [DataMember]
        public string State { get; set; }

        [DataMember]
        public string Country { get; set; }

        public DateTime Created { get; set; }

        public DateTime Updated { get; set; }
    }

    public class GeoPointBinding
    {
        [Required]
        public double Latitude { get; set; }
        
        [Required]
        public double Longitude { get; set; }

        public string Address { get; set; }

        [Required]
        public string Town { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        public string Country { get; set; }

    }
}
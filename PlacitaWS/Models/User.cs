using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;

namespace PlacitaWS.Models
{
    [DataContract]
    public class User
    {
        public int Id { get; set; }

        [DataMember]
        [Required]        
        public String Name { get; set; }

        [DataMember]
        [Required]
        [DataType(DataType.PhoneNumber)]
        public String Phone { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public String Address { get; set; }

        public DateTime Created { get; set; }

        public DateTime Updated { get; set; }
    }
}
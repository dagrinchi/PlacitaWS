﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace PlacitaWS.Models
{
    [DataContract]
    public class Unit
    {
        public Unit()
        {
            Created = DateTime.Now;
            Updated = DateTime.Now;
        }
        
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Code { get; set; }

        [DataMember]
        public string Name { get; set; }

        public DateTime Created { get; set; }

        public DateTime Updated { get; set; }
    }

    public class UnitBinding
    {
        [Required]
        public string Code { get; set; }
        [Required]
        public string Name { get; set; }

    }
}
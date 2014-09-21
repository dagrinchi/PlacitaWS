using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlacitaWS.Models
{
    public class User
    {
        public int Id { get; set; }

        public String Name { get; set; }

        public String Phone { get; set; }

        public DateTime Created { get; set; }

        public DateTime Updated { get; set; }
    }
}
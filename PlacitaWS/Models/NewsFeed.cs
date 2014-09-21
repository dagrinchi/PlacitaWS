using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlacitaWS.Models
{
    public class NewsFeed
    {
        public int Id { get; set; }

        public String Title { get; set; }

        public String Body { get; set; }

        public User Author { get; set; }

        public DateTime Created { get; set; }

        public DateTime Updated { get; set; }
    }
}
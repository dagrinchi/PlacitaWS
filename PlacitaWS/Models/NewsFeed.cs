using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;

namespace PlacitaWS.Models
{
    public class NewsFeed
    {
        public NewsFeed()
        {
            Created = DateTime.Now;
            Updated = DateTime.Now;
        }

        public int Id { get; set; }

        public String Title { get; set; }

        public String Body { get; set; }
    
        public ApplicationUser Author { get; set; }

        public DateTime Created { get; set; }

        public DateTime Updated { get; set; }
    }

    public class NewsFeedBinding
    {
        [Required]
        public String Title { get; set; }

        [Required]
        [DataType(DataType.Html)]
        public String Body { get; set; }

    }
}
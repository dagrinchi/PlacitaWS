using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PlacitaWS.Models
{
    public class PlacitaWSContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public PlacitaWSContext() : base("name=PlacitaWSContext")
        {
        }

        public System.Data.Entity.DbSet<PlacitaWS.Models.Stock> Stocks { get; set; }

        public System.Data.Entity.DbSet<PlacitaWS.Models.Order> Orders { get; set; }

        public System.Data.Entity.DbSet<PlacitaWS.Models.Product> Products { get; set; }

        public System.Data.Entity.DbSet<PlacitaWS.Models.Unit> Units { get; set; }
    
    }
}

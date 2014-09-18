namespace PlacitaWS.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using PlacitaWS.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<PlacitaWS.Models.PlacitaWSContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PlacitaWS.Models.PlacitaWSContext context)
        {
            context.Units.AddOrUpdate(u => u.Code, new Unit
            {
                Code = "LIB",
                Name = "LIBRA",
                Created = DateTime.Now,
                Updated = DateTime.Now
            });
        }
    }
}

namespace PlacitaWS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NuevoGeoPoint : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Prices", "GeoPoint_Id", "dbo.GeoPoints");
            DropIndex("dbo.Prices", new[] { "GeoPoint_Id" });
            AddColumn("dbo.GeoPoints", "Address", c => c.String());
            AddColumn("dbo.GeoPoints", "Town", c => c.String());
            AddColumn("dbo.GeoPoints", "State", c => c.String());
            AddColumn("dbo.GeoPoints", "Country", c => c.String());
            AddColumn("dbo.Places", "IsoCode", c => c.String());
            AddColumn("dbo.Prices", "PriceMaxPerUnit", c => c.Double(nullable: false));
            AddColumn("dbo.Prices", "PriceMinPerUnit", c => c.Double(nullable: false));
            AddColumn("dbo.Prices", "PriceAvgPerUnit", c => c.Double(nullable: false));
            AddColumn("dbo.Prices", "Location", c => c.String());
            DropColumn("dbo.Prices", "PricePerUnit");
            DropColumn("dbo.Prices", "GeoPoint_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Prices", "GeoPoint_Id", c => c.Int());
            AddColumn("dbo.Prices", "PricePerUnit", c => c.Double(nullable: false));
            DropColumn("dbo.Prices", "Location");
            DropColumn("dbo.Prices", "PriceAvgPerUnit");
            DropColumn("dbo.Prices", "PriceMinPerUnit");
            DropColumn("dbo.Prices", "PriceMaxPerUnit");
            DropColumn("dbo.Places", "IsoCode");
            DropColumn("dbo.GeoPoints", "Country");
            DropColumn("dbo.GeoPoints", "State");
            DropColumn("dbo.GeoPoints", "Town");
            DropColumn("dbo.GeoPoints", "Address");
            CreateIndex("dbo.Prices", "GeoPoint_Id");
            AddForeignKey("dbo.Prices", "GeoPoint_Id", "dbo.GeoPoints", "Id");
        }
    }
}

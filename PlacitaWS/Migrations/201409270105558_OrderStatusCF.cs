namespace PlacitaWS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OrderStatusCF : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Address", c => c.String(nullable: false));
            AddColumn("dbo.OrderStatus", "Farmer", c => c.Boolean(nullable: false));
            AddColumn("dbo.OrderStatus", "Buyer", c => c.Boolean(nullable: false));
            AddColumn("dbo.OrderStatus", "Color", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.OrderStatus", "Color");
            DropColumn("dbo.OrderStatus", "Buyer");
            DropColumn("dbo.OrderStatus", "Farmer");
            DropColumn("dbo.Users", "Address");
        }
    }
}

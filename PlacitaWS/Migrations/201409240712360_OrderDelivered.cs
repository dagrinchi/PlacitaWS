namespace PlacitaWS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OrderDelivered : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OrderDelivereds",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Comment = c.String(),
                        Created = c.DateTime(nullable: false),
                        Updated = c.DateTime(nullable: false),
                        Order_Id = c.Int(),
                        OrderStatus_Id = c.Int(),
                        User_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Orders", t => t.Order_Id)
                .ForeignKey("dbo.OrderStatus", t => t.OrderStatus_Id)
                .ForeignKey("dbo.AspNetUsers", t => t.User_Id)
                .Index(t => t.Order_Id)
                .Index(t => t.OrderStatus_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.OrderStatus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Status = c.String(),
                        Created = c.DateTime(nullable: false),
                        Updated = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Orders", "FullName", c => c.String());
            AddColumn("dbo.Orders", "Phone", c => c.String());
            DropColumn("dbo.Orders", "PricePerUnit");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "PricePerUnit", c => c.Double(nullable: false));
            DropForeignKey("dbo.OrderDelivereds", "User_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.OrderDelivereds", "OrderStatus_Id", "dbo.OrderStatus");
            DropForeignKey("dbo.OrderDelivereds", "Order_Id", "dbo.Orders");
            DropIndex("dbo.OrderDelivereds", new[] { "User_Id" });
            DropIndex("dbo.OrderDelivereds", new[] { "OrderStatus_Id" });
            DropIndex("dbo.OrderDelivereds", new[] { "Order_Id" });
            DropColumn("dbo.Orders", "Phone");
            DropColumn("dbo.Orders", "FullName");
            DropTable("dbo.OrderStatus");
            DropTable("dbo.OrderDelivereds");
        }
    }
}

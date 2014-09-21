namespace PlacitaWS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NewsFeeds",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Body = c.String(),
                        Created = c.DateTime(nullable: false),
                        Updated = c.DateTime(nullable: false),
                        Author_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Author_Id)
                .Index(t => t.Author_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Phone = c.String(),
                        Created = c.DateTime(nullable: false),
                        Updated = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Qty = c.Double(nullable: false),
                        PricePerUnit = c.Double(nullable: false),
                        Created = c.DateTime(nullable: false),
                        Updated = c.DateTime(nullable: false),
                        GeoPoint_Id = c.Int(),
                        Stock_Id = c.Int(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.GeoPoints", t => t.GeoPoint_Id)
                .ForeignKey("dbo.Stocks", t => t.Stock_Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.GeoPoint_Id)
                .Index(t => t.Stock_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.GeoPoints",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        latitude = c.Double(nullable: false),
                        longitude = c.Double(nullable: false),
                        Created = c.DateTime(nullable: false),
                        Updated = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Stocks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Qty = c.Double(nullable: false),
                        PricePerUnit = c.Double(nullable: false),
                        ExpiresAt = c.DateTime(nullable: false),
                        Created = c.DateTime(nullable: false),
                        Updated = c.DateTime(nullable: false),
                        GeoPoint_Id = c.Int(),
                        Product_Id = c.Int(),
                        Unit_Id = c.Int(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.GeoPoints", t => t.GeoPoint_Id)
                .ForeignKey("dbo.Products", t => t.Product_Id)
                .ForeignKey("dbo.Units", t => t.Unit_Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.GeoPoint_Id)
                .Index(t => t.Product_Id)
                .Index(t => t.Unit_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Name = c.String(),
                        Created = c.DateTime(nullable: false),
                        Updated = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Units",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Name = c.String(),
                        Created = c.DateTime(nullable: false),
                        Updated = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Prices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PricePerUnit = c.Double(nullable: false),
                        Created = c.DateTime(nullable: false),
                        Updated = c.DateTime(nullable: false),
                        GeoPoint_Id = c.Int(),
                        Product_Id = c.Int(),
                        Unit_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.GeoPoints", t => t.GeoPoint_Id)
                .ForeignKey("dbo.Products", t => t.Product_Id)
                .ForeignKey("dbo.Units", t => t.Unit_Id)
                .Index(t => t.GeoPoint_Id)
                .Index(t => t.Product_Id)
                .Index(t => t.Unit_Id);
            
            AddColumn("dbo.AspNetUsers", "User_Id", c => c.Int());
            CreateIndex("dbo.AspNetUsers", "User_Id");
            AddForeignKey("dbo.AspNetUsers", "User_Id", "dbo.Users", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUsers", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Prices", "Unit_Id", "dbo.Units");
            DropForeignKey("dbo.Prices", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.Prices", "GeoPoint_Id", "dbo.GeoPoints");
            DropForeignKey("dbo.Orders", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Orders", "Stock_Id", "dbo.Stocks");
            DropForeignKey("dbo.Stocks", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Stocks", "Unit_Id", "dbo.Units");
            DropForeignKey("dbo.Stocks", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.Stocks", "GeoPoint_Id", "dbo.GeoPoints");
            DropForeignKey("dbo.Orders", "GeoPoint_Id", "dbo.GeoPoints");
            DropForeignKey("dbo.NewsFeeds", "Author_Id", "dbo.Users");
            DropIndex("dbo.AspNetUsers", new[] { "User_Id" });
            DropIndex("dbo.Prices", new[] { "Unit_Id" });
            DropIndex("dbo.Prices", new[] { "Product_Id" });
            DropIndex("dbo.Prices", new[] { "GeoPoint_Id" });
            DropIndex("dbo.Stocks", new[] { "User_Id" });
            DropIndex("dbo.Stocks", new[] { "Unit_Id" });
            DropIndex("dbo.Stocks", new[] { "Product_Id" });
            DropIndex("dbo.Stocks", new[] { "GeoPoint_Id" });
            DropIndex("dbo.Orders", new[] { "User_Id" });
            DropIndex("dbo.Orders", new[] { "Stock_Id" });
            DropIndex("dbo.Orders", new[] { "GeoPoint_Id" });
            DropIndex("dbo.NewsFeeds", new[] { "Author_Id" });
            DropColumn("dbo.AspNetUsers", "User_Id");
            DropTable("dbo.Prices");
            DropTable("dbo.Units");
            DropTable("dbo.Products");
            DropTable("dbo.Stocks");
            DropTable("dbo.GeoPoints");
            DropTable("dbo.Orders");
            DropTable("dbo.Users");
            DropTable("dbo.NewsFeeds");
        }
    }
}

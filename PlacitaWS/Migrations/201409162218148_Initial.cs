namespace PlacitaWS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Qty = c.Double(nullable: false),
                        PricePerUnit = c.Double(nullable: false),
                        Created = c.DateTime(nullable: false),
                        Updated = c.DateTime(nullable: false),
                        Stock_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Stocks", t => t.Stock_Id)
                .Index(t => t.Stock_Id);
            
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
                        Product_Id = c.Int(),
                        Unit_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.Product_Id)
                .ForeignKey("dbo.Units", t => t.Unit_Id)
                .Index(t => t.Product_Id)
                .Index(t => t.Unit_Id);
            
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "Stock_Id", "dbo.Stocks");
            DropForeignKey("dbo.Stocks", "Unit_Id", "dbo.Units");
            DropForeignKey("dbo.Stocks", "Product_Id", "dbo.Products");
            DropIndex("dbo.Stocks", new[] { "Unit_Id" });
            DropIndex("dbo.Stocks", new[] { "Product_Id" });
            DropIndex("dbo.Orders", new[] { "Stock_Id" });
            DropTable("dbo.Units");
            DropTable("dbo.Products");
            DropTable("dbo.Stocks");
            DropTable("dbo.Orders");
        }
    }
}

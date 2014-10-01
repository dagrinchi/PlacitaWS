namespace PlacitaWS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IdentificationField : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Identification", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "Identification");
        }
    }
}

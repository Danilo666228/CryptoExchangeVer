namespace CryptoExchange.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCompanyMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Photo", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "Photo");
        }
    }
}

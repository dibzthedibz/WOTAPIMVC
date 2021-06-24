namespace WOTAPI.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GUIDadded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "OwnerId", c => c.Guid(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Books", "OwnerId");
        }
    }
}

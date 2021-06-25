namespace WOTAPI.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedGUIDToChapter : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Chapter", "OwnerId", c => c.Guid(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Chapter", "OwnerId");
        }
    }
}

namespace WOTAPI.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedGUIDToCharacter : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Character", "OwnerId", c => c.Guid(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Character", "OwnerId");
        }
    }
}

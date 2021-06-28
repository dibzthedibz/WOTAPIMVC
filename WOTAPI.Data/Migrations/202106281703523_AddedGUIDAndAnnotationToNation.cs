namespace WOTAPI.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedGUIDAndAnnotationToNation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Nation", "OwnerId", c => c.Guid(nullable: false));
            AlterColumn("dbo.Nation", "NationName", c => c.String(nullable: false));
            AlterColumn("dbo.Nation", "Terrain", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Nation", "Terrain", c => c.String());
            AlterColumn("dbo.Nation", "NationName", c => c.String());
            DropColumn("dbo.Nation", "OwnerId");
        }
    }
}

namespace WOTAPI.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedFullName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Character", "FullName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Character", "FullName");
        }
    }
}

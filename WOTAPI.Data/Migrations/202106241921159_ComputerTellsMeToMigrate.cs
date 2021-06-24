namespace WOTAPI.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ComputerTellsMeToMigrate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Books", "Title", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Books", "Title", c => c.String());
        }
    }
}

namespace WOTAPI.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedTradesToString : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Nation", "Trades", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Nation", "Trades");
        }
    }
}

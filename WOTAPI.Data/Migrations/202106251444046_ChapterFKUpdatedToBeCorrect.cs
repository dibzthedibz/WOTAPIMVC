namespace WOTAPI.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChapterFKUpdatedToBeCorrect : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Chapter", "BookId", "dbo.Book");
            DropIndex("dbo.Chapter", new[] { "BookId" });
            AlterColumn("dbo.Chapter", "BookId", c => c.Int(nullable: false));
            CreateIndex("dbo.Chapter", "BookId");
            AddForeignKey("dbo.Chapter", "BookId", "dbo.Book", "BookId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Chapter", "BookId", "dbo.Book");
            DropIndex("dbo.Chapter", new[] { "BookId" });
            AlterColumn("dbo.Chapter", "BookId", c => c.Int());
            CreateIndex("dbo.Chapter", "BookId");
            AddForeignKey("dbo.Chapter", "BookId", "dbo.Book", "BookId");
        }
    }
}

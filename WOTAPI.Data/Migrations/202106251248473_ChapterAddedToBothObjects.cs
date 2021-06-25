namespace WOTAPI.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChapterAddedToBothObjects : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Chapter",
                c => new
                    {
                        ChapterId = c.Int(nullable: false, identity: true),
                        ChapNum = c.Int(nullable: false),
                        ChapTitle = c.String(nullable: false),
                        PageCount = c.Int(nullable: false),
                        BookId = c.Int(),
                    })
                .PrimaryKey(t => t.ChapterId)
                .ForeignKey("dbo.Book", t => t.BookId)
                .Index(t => t.BookId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Chapter", "BookId", "dbo.Book");
            DropIndex("dbo.Chapter", new[] { "BookId" });
            DropTable("dbo.Chapter");
        }
    }
}

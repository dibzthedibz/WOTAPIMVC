namespace WOTAPI.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedCharacterAndFKToChapter : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Character",
                c => new
                    {
                        CharacterId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        Ability = c.String(),
                        Book_BookId = c.Int(),
                    })
                .PrimaryKey(t => t.CharacterId)
                .ForeignKey("dbo.Book", t => t.Book_BookId)
                .Index(t => t.Book_BookId);
            
            AddColumn("dbo.Chapter", "CharacterId", c => c.Int());
            CreateIndex("dbo.Chapter", "CharacterId");
            AddForeignKey("dbo.Chapter", "CharacterId", "dbo.Character", "CharacterId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Character", "Book_BookId", "dbo.Book");
            DropForeignKey("dbo.Chapter", "CharacterId", "dbo.Character");
            DropIndex("dbo.Character", new[] { "Book_BookId" });
            DropIndex("dbo.Chapter", new[] { "CharacterId" });
            DropColumn("dbo.Chapter", "CharacterId");
            DropTable("dbo.Character");
        }
    }
}

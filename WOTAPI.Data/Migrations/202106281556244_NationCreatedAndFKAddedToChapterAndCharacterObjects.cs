namespace WOTAPI.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NationCreatedAndFKAddedToChapterAndCharacterObjects : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Chapter", "CharacterId", "dbo.Character");
            AddColumn("dbo.Chapter", "NationId", c => c.Int());
            AddColumn("dbo.Chapter", "Character_CharacterId", c => c.Int());
            AddColumn("dbo.Character", "NationId", c => c.Int());
            CreateIndex("dbo.Chapter", "NationId");
            CreateIndex("dbo.Chapter", "Character_CharacterId");
            CreateIndex("dbo.Character", "NationId");
            AddForeignKey("dbo.Character", "NationId", "dbo.Character", "CharacterId");
            AddForeignKey("dbo.Chapter", "NationId", "dbo.Character", "CharacterId");
            AddForeignKey("dbo.Chapter", "Character_CharacterId", "dbo.Character", "CharacterId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Chapter", "Character_CharacterId", "dbo.Character");
            DropForeignKey("dbo.Chapter", "NationId", "dbo.Character");
            DropForeignKey("dbo.Character", "NationId", "dbo.Character");
            DropIndex("dbo.Character", new[] { "NationId" });
            DropIndex("dbo.Chapter", new[] { "Character_CharacterId" });
            DropIndex("dbo.Chapter", new[] { "NationId" });
            DropColumn("dbo.Character", "NationId");
            DropColumn("dbo.Chapter", "Character_CharacterId");
            DropColumn("dbo.Chapter", "NationId");
            AddForeignKey("dbo.Chapter", "CharacterId", "dbo.Character", "CharacterId");
        }
    }
}

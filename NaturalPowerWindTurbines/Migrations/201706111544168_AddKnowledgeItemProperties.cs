namespace NaturalPowerWindTurbines.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddKnowledgeItemProperties : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EntryStatus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.KnowledgeCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Manufacturers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.KnowledgeItems", "EntryStatusID_Id", c => c.Int(nullable: false));
            AddColumn("dbo.KnowledgeItems", "KnowlwdgeCateogoryID_Id", c => c.Int(nullable: false));
            AddColumn("dbo.KnowledgeItems", "ManufacturerID_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.KnowledgeItems", "EntryStatusID_Id");
            CreateIndex("dbo.KnowledgeItems", "KnowlwdgeCateogoryID_Id");
            CreateIndex("dbo.KnowledgeItems", "ManufacturerID_Id");
            AddForeignKey("dbo.KnowledgeItems", "EntryStatusID_Id", "dbo.EntryStatus", "Id", cascadeDelete: true);
            AddForeignKey("dbo.KnowledgeItems", "KnowlwdgeCateogoryID_Id", "dbo.KnowledgeCategories", "Id", cascadeDelete: true);
            AddForeignKey("dbo.KnowledgeItems", "ManufacturerID_Id", "dbo.Manufacturers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.KnowledgeItems", "ManufacturerID_Id", "dbo.Manufacturers");
            DropForeignKey("dbo.KnowledgeItems", "KnowlwdgeCateogoryID_Id", "dbo.KnowledgeCategories");
            DropForeignKey("dbo.KnowledgeItems", "EntryStatusID_Id", "dbo.EntryStatus");
            DropIndex("dbo.KnowledgeItems", new[] { "ManufacturerID_Id" });
            DropIndex("dbo.KnowledgeItems", new[] { "KnowlwdgeCateogoryID_Id" });
            DropIndex("dbo.KnowledgeItems", new[] { "EntryStatusID_Id" });
            DropColumn("dbo.KnowledgeItems", "ManufacturerID_Id");
            DropColumn("dbo.KnowledgeItems", "KnowlwdgeCateogoryID_Id");
            DropColumn("dbo.KnowledgeItems", "EntryStatusID_Id");
            DropTable("dbo.Manufacturers");
            DropTable("dbo.KnowledgeCategories");
            DropTable("dbo.EntryStatus");
        }
    }
}

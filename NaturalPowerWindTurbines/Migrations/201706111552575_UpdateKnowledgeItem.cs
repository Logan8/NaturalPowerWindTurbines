namespace NaturalPowerWindTurbines.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateKnowledgeItem : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.KnowledgeItems", name: "EntryStatusID_Id", newName: "EntryStatusId");
            RenameColumn(table: "dbo.KnowledgeItems", name: "KnowlwdgeCateogoryID_Id", newName: "KnowledgeCateogoryId");
            RenameColumn(table: "dbo.KnowledgeItems", name: "ManufacturerID_Id", newName: "ManufacturerId");
            RenameIndex(table: "dbo.KnowledgeItems", name: "IX_EntryStatusID_Id", newName: "IX_EntryStatusId");
            RenameIndex(table: "dbo.KnowledgeItems", name: "IX_ManufacturerID_Id", newName: "IX_ManufacturerId");
            RenameIndex(table: "dbo.KnowledgeItems", name: "IX_KnowlwdgeCateogoryID_Id", newName: "IX_KnowledgeCateogoryId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.KnowledgeItems", name: "IX_KnowledgeCateogoryId", newName: "IX_KnowlwdgeCateogoryID_Id");
            RenameIndex(table: "dbo.KnowledgeItems", name: "IX_ManufacturerId", newName: "IX_ManufacturerID_Id");
            RenameIndex(table: "dbo.KnowledgeItems", name: "IX_EntryStatusId", newName: "IX_EntryStatusID_Id");
            RenameColumn(table: "dbo.KnowledgeItems", name: "ManufacturerId", newName: "ManufacturerID_Id");
            RenameColumn(table: "dbo.KnowledgeItems", name: "KnowledgeCateogoryId", newName: "KnowlwdgeCateogoryID_Id");
            RenameColumn(table: "dbo.KnowledgeItems", name: "EntryStatusId", newName: "EntryStatusID_Id");
        }
    }
}

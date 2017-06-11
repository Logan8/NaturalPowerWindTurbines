namespace NaturalPowerWindTurbines.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReformatKnowledgeItem : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.KnowledgeItems", "Details", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.KnowledgeItems", "Details", c => c.String());
        }
    }
}

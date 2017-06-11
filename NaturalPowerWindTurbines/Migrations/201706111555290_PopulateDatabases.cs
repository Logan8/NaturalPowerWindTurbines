namespace NaturalPowerWindTurbines.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateDatabases : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO EntryStatus (Name) VALUES ('Verified')");
            Sql("INSERT INTO EntryStatus (Name) VALUES ('For Review')");
            Sql("INSERT INTO EntryStatus (Name) VALUES ('Unconfirmed')");

            Sql("INSERT INTO KnowledgeCategories (Name) VALUES ('Maintenance Issue')");
            Sql("INSERT INTO KnowledgeCategories (Name) VALUES ('BOP Issue')");
            Sql("INSERT INTO KnowledgeCategories (Name) VALUES ('Warranty Issue')");

            Sql("INSERT INTO Manufacturers (Name) VALUES ('Nordex')");
            Sql("INSERT INTO Manufacturers (Name) VALUES ('Siemens')");
            Sql("INSERT INTO Manufacturers (Name) VALUES ('Senvion')");
            Sql("INSERT INTO Manufacturers (Name) VALUES ('Vestas')");
        }
        
        public override void Down()
        {
        }
    }
}

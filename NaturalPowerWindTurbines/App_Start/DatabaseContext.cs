using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using NaturalPowerWindTurbines.Models;

namespace NaturalPowerWindTurbines.App_Start
{
    public class DatabaseContext : DbContext
    {
        public DbSet<KnowledgeItem> KnowledgeItemDb { get; set; }
        public DbSet<EntryStatus> EntryStatusDb { get; set; }
        public DbSet<KnowledgeCategory> KnowledgeCategoryDb { get; set; }
        public DbSet<Manufacturer> ManufacturerDb { get; set; }

        public void SeedData()
        {
            using (var db = new DatabaseContext())
            {
                var entryStatus1 = new EntryStatus { Name = "Verified" };
                var entryStatus2 = new EntryStatus { Name = "For Review" };
                var entryStatus3 = new EntryStatus { Name = "Unconfirmed" };

                db.EntryStatusDb.Add(entryStatus1);
                db.EntryStatusDb.Add(entryStatus2);
                db.EntryStatusDb.Add(entryStatus3);

                var knowledgeCategory1 = new KnowledgeCategory { Name = "Mainteance Issue" };
                var knowledgeCategory2 = new KnowledgeCategory { Name = "BOP Issue" };
                var knowledgeCategory3 = new KnowledgeCategory { Name = "Warranty Issue" };

                db.KnowledgeCategoryDb.Add(knowledgeCategory1);
                db.KnowledgeCategoryDb.Add(knowledgeCategory2);
                db.KnowledgeCategoryDb.Add(knowledgeCategory3);

                var manufacturer1 = new Manufacturer { Name = "Nordex" };
                var manufacturer2 = new Manufacturer { Name = "Siemens" };
                var manufacturer3 = new Manufacturer { Name = "Senvion" };
                var manufacturer4 = new Manufacturer { Name = "Vestas" };

                db.ManufacturerDb.Add(manufacturer1);
                db.ManufacturerDb.Add(manufacturer2);
                db.ManufacturerDb.Add(manufacturer3);
                db.ManufacturerDb.Add(manufacturer4);

                var knowledgeItem1 = new KnowledgeItem
                {
                    Details = "Details of Knowledge Item 1.",
                    WindFarm = "Wind Farm of Knowledge Item 1",
                    DateOfInformation = DateTime.Now,
                    ManufacturerId = 1,
                    EntryStatusId = 1,
                    KnowledgeCateogoryId = 1,
                    CreatedBy = "Neil Logan",
                    CreatedOn = DateTime.Now.AddDays(-1)
                };

                var knowledgeItem2 = new KnowledgeItem
                {
                    Details = "Details of Knowledge Item 2.",
                    WindFarm = "Wind Farm of Knowledge Item 2",
                    DateOfInformation = DateTime.Now,
                    ManufacturerId = 2,
                    EntryStatusId = 2,
                    KnowledgeCateogoryId = 2,
                    CreatedBy = "Neil Logan",
                    CreatedOn = DateTime.Now.AddDays(-2)
                };

                var knowledgeItem3 = new KnowledgeItem
                {
                    Details = "Details of Knowledge Item 3.",
                    WindFarm = "Wind Farm of Knowledge Item 3",
                    DateOfInformation = DateTime.Now,
                    ManufacturerId = 3,
                    EntryStatusId = 3,
                    KnowledgeCateogoryId = 3,
                    CreatedBy = "Neil Logan",
                    CreatedOn = DateTime.Now.AddDays(-3)
                };

                db.KnowledgeItemDb.Add(knowledgeItem1);
                db.KnowledgeItemDb.Add(knowledgeItem2);
                db.KnowledgeItemDb.Add(knowledgeItem3);

                db.SaveChanges();
            }
        }
    }
}


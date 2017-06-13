using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NaturalPowerWindTurbines.Models;
using System.Data.Entity;

namespace NaturalPowerWindTurbines.DAL
{
    //Recreating the database each time for development purposes
    public class WindTurbinesInitialiser : DropCreateDatabaseAlways<WindTurbinesContext>
    {
        public WindTurbinesInitialiser()
        {

        }

        protected override void Seed(WindTurbinesContext context)
        {
            var entryStatuses = new List<EntryStatus>
            {
                new EntryStatus { Id = 1, Name = "Verified" },
                new EntryStatus { Id = 2, Name = "For Review" },
                new EntryStatus { Id = 3, Name = "Unconfirmed" }
            };

            entryStatuses.ForEach(e => context.EntryStatus.Add(e));
            context.SaveChanges();

            var manuafcturers = new List<Manufacturer>
            {
                new Manufacturer { Id = 1, Name = "Nordex" },
                new Manufacturer { Id = 2, Name = "Siemens" },
                new Manufacturer { Id = 3, Name = "Senvion" },
                new Manufacturer { Id = 4, Name = "Vestas" }
            };

            manuafcturers.ForEach(m => context.Manufacturer.Add(m));
            context.SaveChanges();

            var knowledgeCategories = new List<KnowledgeCategory>
            {
                new KnowledgeCategory { Id = 1, Name = "Mainteance Issue" },
                new KnowledgeCategory { Id = 2, Name = "BOP Issue" },
                new KnowledgeCategory { Id = 3, Name = "Warranty Issue" }
            };

            knowledgeCategories.ForEach(k => context.KnowledgeCategory.Add(k));
            context.SaveChanges();

            var knowledgeItems = new List<KnowledgeItem>
            {
                new KnowledgeItem
                {
                    Id = 1,
                    Details = "Details of Knowledge Item 1.",
                    WindFarm = "Wind Farm of Knowledge Item 1",
                    DateOfInformation = DateTime.Now.ToString(),
                    ManufacturerId = 1,
                    EntryStatusId = 1,
                    KnowledgeCateogoryId = 1,
                    CreatedBy = "Neil Logan",
                    CreatedOn = DateTime.Now.AddDays(-1).ToString()
                },

                new KnowledgeItem
                {
                    Id = 2,
                    Details = "Details of Knowledge Item 2.",
                    WindFarm = "Wind Farm of Knowledge Item 2",
                    DateOfInformation = DateTime.Now.ToString(),
                    ManufacturerId = 2,
                    EntryStatusId = 2,
                    KnowledgeCateogoryId = 2,
                    CreatedBy = "Neil Logan",
                    CreatedOn = DateTime.Now.AddDays(-2).ToString()
                },

                new KnowledgeItem
                {
                    Id = 3,
                    Details = "Details of Knowledge Item 3.",
                    WindFarm = "Wind Farm of Knowledge Item 3",
                    DateOfInformation = DateTime.Now.ToString(),
                    ManufacturerId = 3,
                    EntryStatusId = 3,
                    KnowledgeCateogoryId = 3,
                    CreatedBy = "Neil Logan",
                    CreatedOn = DateTime.Now.AddDays(-3).ToString()
                }
            };

            knowledgeItems.ForEach(k => context.KnowledgeItem.Add(k));
            context.SaveChanges();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NaturalPowerWindTurbines.Models;
using System.Data.Entity;

namespace NaturalPowerWindTurbines.DAL
{
    public class WindTurbinesContext : DbContext
    {
        public WindTurbinesContext(): base()
        {

        }

        public DbSet<KnowledgeItem> KnowledgeItem { get; set; }
        public DbSet<EntryStatus> EntryStatus { get; set; }
        public DbSet<Manufacturer> Manufacturer { get; set; }
        public DbSet<KnowledgeCategory> KnowledgeCategory { get; set; }        
    }
}
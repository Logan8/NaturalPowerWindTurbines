using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NaturalPowerWindTurbines.Models;

namespace NaturalPowerWindTurbines.ViewModels
{
    public class KnowledgeItemShowViewModel
    {
        public IEnumerable<EntryStatus> EntryStatus { get; set; }
        public IEnumerable<KnowledgeCategory> KnowledgeCategory { get; set; }
        public IEnumerable<Manufacturer> Manufacturer { get; set; }
        public KnowledgeItem KnowledgeItem { get; set; }
    }
}
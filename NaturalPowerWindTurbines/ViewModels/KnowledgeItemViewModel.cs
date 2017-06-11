using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NaturalPowerWindTurbines.Models;

namespace NaturalPowerWindTurbines.ViewModels
{
    public class KnowledgeItemViewModel
    {
        public KnowledgeItem KnowledgeItem { get; set; }
        public List<EntryStatus> EntryStatus { get; set; }
        public List<KnowledgeCategory> KnowledgeCategory { get; set; }
        public List<Manufacturer> Manufacturer { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace NaturalPowerWindTurbines.Models
{
    public class KnowledgeItem
    {
        public int Id { get; set; }

        [Required]
        public string Details { get; set; }

        public string WindFarm { get; set; }

        public DateTime DateOfInformation { get; set; }

        [Required]
        public int EntryStatusId { get; set; }
        public EntryStatus EntryStatus { get; set; }

        [Required]
        public int ManufacturerId { get; set; }
        public Manufacturer Manufacturer { get; set; }

        [Required]
        public int KnowledgeCateogoryId { get; set; }
        public KnowledgeCategory KnowledgeCateogory { get; set; }
        
        [Required]
        public string CreatedBy { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }
    }
}
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

        [Display(Name = "Name of Wind Farm") ]
        public string WindFarm { get; set; }

        [Display(Name = "Date of Information")]
        public DateTime DateOfInformation { get; set; }

        [Required]
        [Display(Name = "Entry Status")]
        public int EntryStatusId { get; set; }
        public EntryStatus EntryStatus { get; set; }

        [Required]
        [Display(Name = "Manufacturer")]
        public int ManufacturerId { get; set; }
        public Manufacturer Manufacturer { get; set; }

        [Required]
        [Display(Name = "Knowledge Category")]
        public int KnowledgeCateogoryId { get; set; }
        public KnowledgeCategory KnowledgeCateogory { get; set; }
        
        [Required]
        [Display(Name = "Created By")]
        public string CreatedBy { get; set; }

        [Required]
        [Display(Name = "Created On")]
        public DateTime CreatedOn { get; set; }
    }
}
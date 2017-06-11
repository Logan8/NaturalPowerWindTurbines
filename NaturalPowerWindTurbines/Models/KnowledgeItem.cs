using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace NaturalPowerWindTurbines.Models
{
    public class KnowledgeItem
    {
        [Required]
        public int Id { get; set; }

        public string Details { get; set; }

        public string WindFarm { get; set; }

        public DateTime DateOfInformation { get; set; }

        /*[Required]
        public Manufacturer ManufacturerID { get; set; }

        [Required]
        public EntryStatus EntryStatusID { get; set; }

        [Required]
        public KnowledgeCategory KnowlwdgeCateogory { get; set; }*/

        [Required]
        public string CreatedBy { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }
    }
}
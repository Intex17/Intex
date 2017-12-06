using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Intex2.Models
{
    [Table("Assay")]
    public class Assay
    {
        [Key]
        [HiddenInput(DisplayValue = true)]
        public int assayID { get; set; }
        public string assayType { get; set; }
        public string assayProtocol { get; set; }
        public decimal assayPctCompletion { get; set; }
        public string assayName { get; set; }
        public decimal assayBaseCost { get; set; }

        [ForeignKey("orderNumber")]
        public int? orderNumber { get; set; }
    }
}
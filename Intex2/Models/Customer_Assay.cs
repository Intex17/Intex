using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Intex2.Models
{
    [Table("Customer_Assay")]
    public class Customer_Assay
    {
        [ForeignKey("orderNumber")]
        public int? orderNumber { get; set; }

        [ForeignKey("assayID")]
        public int? assayID { get; set; }
    }
}
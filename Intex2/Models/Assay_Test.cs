using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Intex2.Models
{
    [Table("Assay_Test")]
    public class Assay_Test
    {
        [ForeignKey("assayID")]
        public int? assayID { get; set; }

        [ForeignKey("testID")]
        public int? testID { get; set; }

        public int assayTestRequired { get; set; }
    }
}
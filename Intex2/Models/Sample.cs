using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Intex2.Models
{
    [Table("Sample")]
    public class Sample
    {
        [Key]
        public int sampleSequenceCode { get; set; }
        [Key]
        public int sampleLTnum { get; set; }
        public int sampleTested { get; set; }
        public decimal sampleTestHours { get; set; }
        public decimal sampleTestedAmount { get; set; }
        public string sampleResults { get; set; }

        [ForeignKey("assayID")]
        public int? assayID { get; set; }
    }
}
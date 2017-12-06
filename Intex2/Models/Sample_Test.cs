using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Intex2.Models
{
    [Table("Sample_Test")]
    public class Sample_Test
    {
        [Key]
        public int sampleTestCode { get; set; }
        public decimal samplePctCompletion { get; set; }

        [ForeignKey("sampleSequenceCode")]
        public int? sampleSequenceCode { get; set; }

        [ForeignKey ("sampleLTnum")]
        public int? sampleLTnum { get; set; }

        [ForeignKey ("testID")]
        public int? testID { get; set; }
    }
}
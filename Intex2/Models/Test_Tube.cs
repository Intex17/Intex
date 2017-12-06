using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Intex2.Models
{
    [Table("Test_Tube")]
    public class Test_Tube
    {
        [Key]
        public int tubeNumber { get; set; }
        public decimal tubeAmount { get; set; }
        public int tubeActive { get; set; }
        public int tubeTested { get; set; }
        public decimal tubePctCompletion { get; set; }
        public decimal tubeTestHours { get; set; }
        public string tubeDate { get; set; }
        public string tubeResults { get; set; }

        [ForeignKey("sampleTestCode")]
        public int? sampleTestCode { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Intex2.Models
{
    [Table("Task")]
    public class Tasks
    {
        [Key]
        public int taskID { get; set; }
        public string taskName { get; set; }
        public string taskDesc { get; set; }
        
        [ForeignKey("tubeNumber")]
        public int? tubeNumber { get; set; }
    }
}
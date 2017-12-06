using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Intex2.Models
{
    public class Employee
    {
        [Key]
        public int empID { get; set; }
        public string empFirstName { get; set; }
        public string empLastName { get; set; }
        public string empSSNHas { get; set; }
        public decimal empWage { get; set; }
        public string empEmail { get; set; }
    }
}
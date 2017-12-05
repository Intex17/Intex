using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Intex2.Models
{
    public class Representative
    {
        //enter in validation stuff
        [Key]
        public int repID { get; set; }
        public string repFirstName { get; set; }
        public string repLastName { get; set; }
        public string repPhoneNumber { get; set; }
        public string repEmail { get; set; }
        public string repUserName { get; set; }
        public string repPasswordHash { get; set; }
    }
}
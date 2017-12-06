using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Intex2.Models
{
    public class NewRegister
    {
        
        [Key]
        public int registerId { get; set; }

        [Required]
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [Required]
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [Required]
        [DisplayName("Company")]
        public string Company { get; set; }
        [Required]
        [DisplayName("Phone")]
        public string Phone { get; set; }
        [Required]
        [DisplayName("Address 1")]
        public string Address1 { get; set; }
        [Required]
        [DisplayName("Address 2")]
        public string Address2 { get; set; }
        [Required]
        [DisplayName("City")]
        public string City { get; set; }
        [Required]
        [DisplayName("State")]
        public string State { get; set; }
        [Required]
        [DisplayName("Zipcode")]
        public int Zipcode { get; set; }
    }
}
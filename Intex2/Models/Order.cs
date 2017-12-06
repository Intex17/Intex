using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Intex2.Models
{
    [Table("Order")]
    public class Order
    {
        [Key]
        [HiddenInput(DisplayValue = true)]
        public int orderNumber { get; set; }
        public string orderDate { get; set; }
        public int orderStatusID { get; set; }
        public string orderDateDue { get; set; }
        public decimal orderPctCompletion { get; set; }
        public string orderCustomerComment { get; set; }
        public int orderDeliveryPaper { get; set; }
        public int orderDeliveryElectronic { get; set; }
        public decimal orderAdvancePayment { get; set; }

        public int? clientID { get; set; }

    }
}
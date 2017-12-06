using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Intex2.Models
{
    public class ClientLink
    {
        public Client Clients { get; set; }
        public Representative Representative { get; set; }
        public NewRegister NewRegisters { get; set; }
        public Assay Assay { get; set; }
        public Assay_Test Assay_Test { get; set; }
        public Customer_Assay Customer_Assay { get; set; }
        public Order Order { get; set; }
        public Sample Sample { get; set; }
        public Tasks Tasks { get; set; }
        public Test_Tube Test_Tube { get; set; }
    }
}
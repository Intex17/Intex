using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Intex2.Models;
using System.Data.Entity;

namespace Intex2.DAL
{
    public class IntexContext:DbContext
    {
        public IntexContext() : base("IntexContext")
        {

        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Representative> Representative { get; set; }
        public DbSet<NewRegister> NewRegisters { get; set; }
        public DbSet<Assay> Assay { get; set; }
        public DbSet<Assay_Test> Assay_Test { get; set; }
        public DbSet<Customer_Assay> Customer_Assay { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Sample> Sample { get; set; }
        public DbSet<Task> Task { get; set; }
        public DbSet<Test_Tube> Test_Tube { get; set; }

    }
}
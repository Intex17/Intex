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
    }
}
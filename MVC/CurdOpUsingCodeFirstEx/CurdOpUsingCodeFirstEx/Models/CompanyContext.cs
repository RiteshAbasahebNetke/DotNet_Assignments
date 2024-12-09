using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CurdOpUsingCodeFirstEx.Models
{
    public class CompanyContext:DbContext
    {
        public DbSet<Area> Areas { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
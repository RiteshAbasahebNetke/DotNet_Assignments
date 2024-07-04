using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Code_First.Models
{
    public class CompanyContext:DbContext
    {
        public DbSet<Customer> Customers { get; set; }
    }
}
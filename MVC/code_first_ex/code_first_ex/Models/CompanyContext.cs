using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace code_first_ex.Models
{
    public class CompanyContext:DbContext
    {
        public CompanyContext() : base("scon") { }
        public DbSet<Emp> Emps { get; set; }
        public DbSet<Dept> Depts { get; set; }
        public DbSet<Area> Areas { get; set; }
    }
}
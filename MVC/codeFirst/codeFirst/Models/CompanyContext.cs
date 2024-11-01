using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace codeFirst.Models
{
    public class CompanyContext:DbContext
    {
        public DbSet<Emp> Emps { get; set; }
        public DbSet<Dept> Depts { get; set; }
    }
}
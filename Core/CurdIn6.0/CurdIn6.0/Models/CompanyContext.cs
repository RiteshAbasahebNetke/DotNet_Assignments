using Microsoft.EntityFrameworkCore;

namespace CurdIn6._0.Models
{
    public class CompanyContext:DbContext
    {
      public CompanyContext(DbContextOptions<CompanyContext> opt) : base(opt) { }
      public DbSet<Dept> Department { get; set; }
        public DbSet<Emp> Emps { get; set; }
    }
}

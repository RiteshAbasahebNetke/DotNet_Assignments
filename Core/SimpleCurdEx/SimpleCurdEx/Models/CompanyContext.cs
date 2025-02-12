using Microsoft.EntityFrameworkCore;

namespace SimpleCurdEx.Models
{
    public class CompanyContext:DbContext
    {
        public CompanyContext(DbContextOptions<CompanyContext> opt):base(opt){}
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Dept>().HasData(
                new Dept { DeptID = 1, DeptName = "Computer" },
                new Dept { DeptID = 2, DeptName = "Sales" },
                new Dept { DeptID = 3, DeptName = "Purchase" }
                );
        }
        public DbSet<Dept> Depts { get; set; }
        public DbSet<Emp> Emps { get; set; }    
    }
}

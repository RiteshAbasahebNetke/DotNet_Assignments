using Microsoft.EntityFrameworkCore;

namespace curdEX.Models
{
    public class CompanyContext:DbContext
    {
        public CompanyContext(DbContextOptions<CompanyContext> opt) : base(opt) { }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Dept>().HasData(
                new Dept() { DeptID = 1, DeptName = "Sales" },
                new Dept() { DeptID = 2, DeptName = "Computer" },
                new Dept() { DeptID = 3, DeptName = "Marketing" });
        }
        public DbSet<Dept> Depts { get; set; }
        public DbSet<Emp> Emps { get; set; }
    }
}

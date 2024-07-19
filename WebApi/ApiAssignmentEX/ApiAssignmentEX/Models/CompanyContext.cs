using Microsoft.EntityFrameworkCore;

namespace ApiAssignmentEX.Models
{
    public class CompanyContext:DbContext
    {
        public CompanyContext(DbContextOptions<CompanyContext> opt) : base(opt) { }
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Dept>().HasData(
                new Dept() { DeptID=1,DeptName="Computer"},
                new Dept() { DeptID = 2, DeptName = "Production" },
                new Dept() { DeptID = 3, DeptName = "Purchase" },
                new Dept() { DeptID = 4, DeptName = "Sales" }
                );

            mb.Entity<Emp>().HasData(
                new Emp() { EmpID=1,EmpName="Sham",DeptID=1, Salary=30000},
                new Emp() { EmpID = 2, EmpName = "Ramesh", DeptID = 4, Salary = 78000 },
                new Emp() { EmpID = 3, EmpName = "Suresh", DeptID = 1, Salary = 39000 },
                new Emp() { EmpID = 4, EmpName = "Arun", DeptID = 2, Salary = 18000 },
                new Emp() { EmpID = 5, EmpName = "Raj", DeptID = 3, Salary = 45000 }
                );
        }
        public DbSet<Emp> Emps { get; set; }
        public DbSet<Dept> Depts { get; set; }
    }
}

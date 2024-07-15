using Microsoft.EntityFrameworkCore;

namespace CurdUsing_6Version.Models
{
    public class CompanyContext:DbContext
    {
        public CompanyContext(DbContextOptions<CompanyContext>opt):base(opt) { }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Dept>().HasData(
                new Dept() { DeptID = 1,DeptName="Computer" },
                new Dept() { DeptID=2,DeptName="HR"},
                new Dept() { DeptID=3,DeptName="Process"}
                );

            mb.Entity<Emp>().HasData(
                new Emp() { EmpID=1,EmpName="Suresh",EmailID="suresh@gmail.com",Address="Akurdi",Salary=23000,DeptID=2},
                new Emp() { EmpID = 2, EmpName = "Manish", EmailID = "manish@hotmail.com", Address = "Pimpri", Salary = 27000, DeptID = 3 },
                new Emp() { EmpID = 3, EmpName = "Raj", EmailID = "raj@gmail.com", Address = "Nigdi", Salary = 33000, DeptID =1 }
                );
        }
        public DbSet<Dept> Depts { get; set; }
        public DbSet<Emp> Emps { get; set; }
    }
}

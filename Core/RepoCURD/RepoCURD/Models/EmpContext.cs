using Microsoft.EntityFrameworkCore;

namespace RepoCURD.Models
{
    public class EmpContext:DbContext
    {
        EmpContext ec;
        public EmpContext(DbContextOptions<EmpContext> opt) : base(opt) { }
        protected  override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Emp>().HasData(
                new Emp() { EmpID = 10, EmpName = "Sham", EmailID = "sham@gmail.com", Salary = 40000,DeptID=2 },
                new Emp() { EmpID=23,EmpName="Ram",EmailID="ram@hotmail.com",Salary=35000,DeptID=1}
                );
        }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Emp> Emps { get; set; }
    }
}

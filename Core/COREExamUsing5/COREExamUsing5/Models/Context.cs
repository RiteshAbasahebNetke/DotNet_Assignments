using Microsoft.EntityFrameworkCore;

namespace COREExamUsing5.Models
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> opt) : base(opt) { }
        public DbSet<Emp> Emps { get; set; }
        public DbSet<EmpSalary> EmpSalaries { get; set; }
        public DbSet<SalaryDeduction> SalaryDeductions { get; set; }
        public DbSet<SalaryAddtion> SalaryAddtions { get; set; }

    }
}

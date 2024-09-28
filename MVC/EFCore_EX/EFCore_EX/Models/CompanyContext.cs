using Microsoft.EntityFrameworkCore;

namespace EFCore_EX.Models
{
    public class CompanyContext:DbContext
    {
        public CompanyContext(DbContextOptions<CompanyContext> opt) : base(opt) { }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Emp> Emps { get; set; }
    }
}

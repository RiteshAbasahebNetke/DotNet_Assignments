using Microsoft.EntityFrameworkCore;

namespace Repo_Curd.Models
{
    public class EmpContext : DbContext
    {
        public EmpContext(DbContextOptions<EmpContext> opt) : base(opt) { }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Emp> Emps { get; set; }
    }
}

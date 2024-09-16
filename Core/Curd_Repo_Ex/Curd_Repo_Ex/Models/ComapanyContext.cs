using Microsoft.EntityFrameworkCore;

namespace Curd_Repo_Ex.Models
{
    public class ComapanyContext:DbContext
    {
        public ComapanyContext(DbContextOptions<ComapanyContext> opt) : base(opt) { }
        public DbSet<Dept> Depts { get; set; }
        public DbSet<Emp> Emps { get; set; }
    }
}

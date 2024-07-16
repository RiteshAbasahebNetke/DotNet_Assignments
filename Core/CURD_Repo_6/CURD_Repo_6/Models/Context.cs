using Microsoft.EntityFrameworkCore;

namespace CURD_Repo_6.Models
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> opt) : base(opt) { }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Subject>().HasData(
                new Subject() { SubjectID=1,SubjectName="Marathi"},
                new Subject() { SubjectID=2,SubjectName="GK"},
                new Subject() { SubjectID=3,SubjectName="Algebra"}
                );
        }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}

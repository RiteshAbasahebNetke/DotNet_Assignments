using Microsoft.EntityFrameworkCore;

namespace CurdRepo.Models
{
    public class CourseContext:DbContext
    {
        CourseContext cc;
        public CourseContext(DbContextOptions<CourseContext>opt) : base(opt) { }
        public DbSet<CourseCategory> CourseCategories { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}

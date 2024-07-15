using Microsoft.EntityFrameworkCore;

namespace Curd_Using_Repo.Models
{
    public class CourseContext:DbContext
    {
        public CourseContext(DbContextOptions<CourseContext> opt):base(opt) { }
        public DbSet<CourseCategory> CourseCategories { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}

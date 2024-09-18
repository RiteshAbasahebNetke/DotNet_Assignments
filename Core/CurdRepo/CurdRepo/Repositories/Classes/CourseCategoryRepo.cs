using CurdRepo.Models;
using CurdRepo.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace CurdRepo.Repositories.Classes
{
    public class CourseCategoryRepo : ICourseCategoryRepo
    {
        CourseContext cc;
        public CourseCategoryRepo(CourseContext cc)
        {
            this.cc = cc;
        }
        public List<CourseCategory> GetAllCategories()
        {
            return this.cc.CourseCategories.ToList();
        }
    }
}

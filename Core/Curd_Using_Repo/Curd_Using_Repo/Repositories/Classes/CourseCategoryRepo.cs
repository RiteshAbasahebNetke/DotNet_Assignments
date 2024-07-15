using Curd_Using_Repo.Models;
using Curd_Using_Repo.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Curd_Using_Repo.Repositories.Classes
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

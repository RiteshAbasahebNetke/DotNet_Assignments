using CurdRepo.Models;
using System.Collections.Generic;

namespace CurdRepo.Repositories.Interfaces
{
    public interface ICourseCategoryRepo
    {
        List<CourseCategory> GetAllCategories();
    }
}

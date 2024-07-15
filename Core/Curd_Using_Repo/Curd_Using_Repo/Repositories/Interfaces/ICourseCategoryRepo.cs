using Curd_Using_Repo.Models;
using Curd_Using_Repo.Repositories.Classes;
using System.Collections.Generic;

namespace Curd_Using_Repo.Repositories.Interfaces
{
    public interface ICourseCategoryRepo
    {
        List<CourseCategory> GetAllCategories();
    }
}

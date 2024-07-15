using Curd_Using_Repo.Models;
using System;
using System.Collections.Generic;

namespace Curd_Using_Repo.Repositories.Interfaces
{
    public interface ICourseRepo
    {
        List<Course> GetAll();
        Course GetById(Int64 id);
        void Add(Course rec);
        void Edit(Course rec);
        void Delete(Int64 id);
        List<Course> GetCategoryID(Int64 id);
    }
}

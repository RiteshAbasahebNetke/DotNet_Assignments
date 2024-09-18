using CurdRepo.Models;
using System;
using System.Collections.Generic;

namespace CurdRepo.Repositories.Interfaces
{
    public interface ICourseRepo
    {
        List<Course> GetAll();
        Course GetById(long id);
        void Add(Course rec);
        void Edit(Course rec);
        void Delete(long id);
        List<Course> GetByCategoryID(Int64 id);
    }
}

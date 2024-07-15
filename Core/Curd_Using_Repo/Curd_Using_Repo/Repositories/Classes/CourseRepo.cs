using Curd_Using_Repo.Models;
using Curd_Using_Repo.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Curd_Using_Repo.Repositories.Classes
{
    public class CourseRepo:ICourseRepo
    {
        CourseContext cc;
        public CourseRepo(CourseContext cc)
        {
            this.cc = cc;
        }
        public void Add(Course rec)
        {
            this.cc.Courses.Add(rec);
            this.cc.SaveChanges();
        }

        public void Delete(Int64 id)
        {
            var rec = this.cc.Courses.Find(id);
            this.cc.Courses.Remove(rec);
            this.cc.SaveChanges();
        }

        public void Edit(Course rec)
        {
            this.cc.Entry(rec).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            this.cc.SaveChanges();
        }

        public List<Course> GetAll()
        {
           return this.cc.Courses.ToList();
        }

        public Course GetById(Int64 id)
        {
            return this.cc.Courses.Find(id);
        }

        public List<Course> GetCategoryID(long id)
        {
            var v = from m in this.cc.Courses
                    where m.CourseCategoryID == id
                    select m;

            return v.ToList();
        }
    }
}

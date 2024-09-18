using CurdRepo.Models;
using CurdRepo.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace CurdRepo.Repositories.Classes
{
    public class CourseRepo : ICourseRepo
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

        public List<Course> Courses()
        {
            throw new System.NotImplementedException();
        }

        public void Delete(long id)
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

        public List<Course> GetByCategoryID(long id)
        {
            var v = from m in this.cc.Courses
                    where m.CourseCategoryID == id
                    select m;
            return v.ToList();
        }

        public Course GetById(long id)
        {
            return this.cc.Courses.Find(id);
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Curd_Using_Repo.Models
{
    [Table("Category")]
    public class CourseCategory
    {
        [Key]
        public Int64 CourseCategoryID { get; set; }
        public string CourseCategoryName { get; set; }
        public virtual List<Course> Courses { get; set; }
    }
}
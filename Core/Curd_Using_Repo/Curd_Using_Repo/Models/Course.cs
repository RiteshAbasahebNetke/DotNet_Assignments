using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Curd_Using_Repo.Models
{
    [Table("Course")]
    public class Course
    {
        [Key]
        public Int64 CourseID { get; set; }
        public string CourseName { get; set; }
        public string CourseDesc { get; set; }
        public int DurationInMonths { get; set; }

        [ForeignKey("CourseCategory")]
        public Int64 CourseCategoryID { get; set; }
        public virtual CourseCategory CourseCategory { get; set; }
    }
}

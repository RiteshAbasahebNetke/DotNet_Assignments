using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectExample
{
    public class Course
    {
        int CourseID;
        string CourseName;
        string CourseDuration;
        double CourseFees;

        public void AddCourse()
        {
            CourseID = 12;
            CourseName = "C#";
            CourseDuration = "1 month";
            CourseFees = 2000;
        }
        public void DispCourse()
        {
            Console.WriteLine("CourseID is:" + CourseID);
            Console.WriteLine("CourseName is:" + CourseName);
            Console.WriteLine("CourseDuration is:" + CourseDuration);
            Console.WriteLine("CourseFees is:" + CourseFees);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Course c = new Course();
            c.AddCourse();
            c.DispCourse();
        }
    }
}

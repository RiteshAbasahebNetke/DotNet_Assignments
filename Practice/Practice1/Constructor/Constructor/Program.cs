using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Course        
    {
        private int CourseID;
        private string CourseName;
        private double CourseDuration;
        private double CourseFees;

        public Course()     // Default Constructor
        {
            CourseID = 1;
            CourseName = "C#";
            CourseDuration = 3;
            CourseFees = 4000;
        }
        public Course(int cid,string cn)     //Constructor with 2 parameters
        {
            CourseID = cid;
            CourseName = cn;
        }
        public void DispCourse() 
        {
            Console.WriteLine("CourseID:" + CourseID);
            Console.WriteLine("CourseName:" + CourseName);
            Console.WriteLine("CourseDuration:" + CourseDuration);
            Console.WriteLine("CourseFees:" + CourseFees);
        } 
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Course c = new Course();
            c.DispCourse();

            Course c1 = new Course(2,"VB");
            c1.DispCourse();
        }
    }
}

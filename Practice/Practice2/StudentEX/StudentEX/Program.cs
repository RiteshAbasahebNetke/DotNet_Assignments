using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEX
{
    internal class Student
    {
        private int StudentID;
        private string StudentName;
        private string CourseName;
        private string MobileNo;

        public void AddStudent(int si,string sn,string cn,string mn)
        {
            this.StudentID = si;
            this.StudentName = sn;
            this.CourseName = cn;
            this.MobileNo = mn;
        }

        public void DispStudent()
        {
            Console.WriteLine("StudentID is:"+ StudentID);
            Console.WriteLine("Student Name:"+ StudentName);
            Console.WriteLine("Course Name:" + CourseName); 
            Console.WriteLine("MobileNo:"+ MobileNo);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.AddStudent(1, "Satish", "VB", "9347594882");
            s.DispStudent();
        }
    }
}

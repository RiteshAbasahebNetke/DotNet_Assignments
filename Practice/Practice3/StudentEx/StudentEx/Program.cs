using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEx
{
    class Student
    {
        public int StudentID;
        public string StudentName;
        public string CourseName;
        public string MobileNo;

        public void AddStudent(int si,string sn,string cn,string mn)
        {
            this.StudentID = si;
            this.StudentName = sn;
            this.CourseName = cn;
            this.MobileNo = mn;
        }
        public void DispStudent()
        {
            Console.WriteLine("StudentID:" + this.StudentID);
            Console.WriteLine("Student Name:"+ this.StudentName);
            Console.WriteLine("Course Name:"+ this.CourseName);
            Console.WriteLine("Mobile No:"+ this.MobileNo);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s=new Student();
            s.AddStudent(1, "Rajesh", "VB", "987365000");
            s.DispStudent();

            Student s1=new Student();
            s1.AddStudent(2, "Sham", "C#", "5634322350");
            s1.DispStudent();
        }
    }
}

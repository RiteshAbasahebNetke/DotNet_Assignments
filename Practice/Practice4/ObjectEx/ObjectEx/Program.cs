using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectEx
{
    public class Student
    {
        public int StudentID;
        public string StudentName;
        public string CourseName;
        public string MobileNo;

        public void AddStudent(int sid,string sn,string cn,string m)
        {
            this.StudentID = sid;
            this.StudentName = sn;
            this.CourseName = cn;
            this.MobileNo = m;
        }
        public void DispStudent()
        {
            Console.WriteLine("StudentID is:"+ this.StudentID);
            Console.WriteLine("Student Name is:"+ this.StudentName);
            Console.WriteLine("Course Name is:" + this.CourseName);
            Console.WriteLine("Mobile is:"+ this.MobileNo); 
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s=new Student();
            s.AddStudent(1, "Nikhil", "C#", "475922023");
            s.DispStudent();
        }
    }
}

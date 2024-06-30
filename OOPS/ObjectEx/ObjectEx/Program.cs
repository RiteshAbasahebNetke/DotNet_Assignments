using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectEx
{
    internal class Student
    {
        public int StudentID;
        public string StudentName;
        public string CourseName;
        public string MobileNo;

        public void AddStudent(int si,string sn,string cn,string mn)
        {
            StudentID = si;
            StudentName = sn;
            CourseName = cn;
            MobileNo = mn;
        }
        public void DispStudent()
        {
            Console.WriteLine("StudentID:" + StudentID);
            Console.WriteLine("StudentName:" + StudentName);
            Console.WriteLine("CourseName:" + CourseName);
            Console.WriteLine("MobileNo:" + MobileNo);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.AddStudent(1, "Raj", "C#", "9984303232");
            s.DispStudent();

            Student s1 = new Student();
            s1.AddStudent(2, "Sham", "VB", "3432034309");
            s1.DispStudent();
        }
    }
}

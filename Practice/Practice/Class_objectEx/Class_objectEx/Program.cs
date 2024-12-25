using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Class_objectEx
{
    internal class Program
    {
        class Student
        {
            private int StudentID;
            private string StudentName;
            private string ClassName;
            private int RollNo;

            public void AddStudent(int sid,string sn,string cn,int rn)
            {
                this.StudentID = sid;
                this.StudentName = sn;
                this.ClassName = cn;
                this.RollNo = rn;
            }

            public void DispStudent()
            {
                Console.WriteLine("StuentID:" + this.StudentID);
                Console.WriteLine("Student Name:" + this.StudentName);
                Console.WriteLine("Class Name:" + this.ClassName);
                Console.WriteLine("Roll No:" + this.RollNo);
            }
        }
        static void Main(string[] args)
        {
            Student s=new Student();
            s.AddStudent(1, "Satish", "Fifth", 12);
            s.DispStudent();
        }
    }
}

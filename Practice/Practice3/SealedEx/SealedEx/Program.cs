using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedEx
{
    sealed class Student
    {
        public int RollNo;
        public string StudentName;
        public string Address;
        public string Sclass;

        public void AddStudent(int rn,string sn,string a,string cn)
        {
            this.RollNo = rn;
            this.StudentName = sn;
            this.Address = a;
            this.Sclass = sn;
        }
        public void DispStudent()
        {
            Console.WriteLine("Roll No:" + this.RollNo);
            Console.WriteLine("Student Name:" + this.StudentName);
            Console.WriteLine("Address:"+ this.Address);
            Console.WriteLine("SClass:"+this.Sclass);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s=new Student();
            s.AddStudent(1, "Rajesh", "Nigdi", "5th Std");
            s.DispStudent();
        }
    }
}

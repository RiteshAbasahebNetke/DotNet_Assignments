using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LinqToObjectEx
{
    class Emp
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public string DeptName { get; set; }
        public decimal Salary { get; set; }
        public string MobileNo { get; set; }
        public void DispEmp()
        {
            Console.WriteLine("Emp ID:" + this.EmpID);
            Console.WriteLine("Emp Name:" + this.EmpName);
            Console.WriteLine("Dept Name:" + this.DeptName);
            Console.WriteLine("Salary :" + this.Salary);
            Console.WriteLine("Mobile No:" + this.MobileNo);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {           

            List<Emp> lst = new List<Emp>();
            lst.Add(new Emp() { EmpID = 2, EmpName = "Sunil", DeptName = "Computer", MobileNo = "99878768", Salary = 45000 });
            lst.Add(new Emp() { EmpID = 3, EmpName = "Amit", DeptName = "Sales", MobileNo = "98067878", Salary = 10000 });
            lst.Add(new Emp() { EmpID = 4, EmpName = "Ajit", DeptName = "Computer", MobileNo = "8908678768", Salary = 12000 });
            lst.Add(new Emp() { EmpID = 5, EmpName = "Sudhir", DeptName = "Puchase", MobileNo = "789678768", Salary = 18000 });
            lst.Add(new Emp() { EmpID = 6, EmpName = "Suresh", DeptName = "Sales", MobileNo = "898678768", Salary = 34000 });
            lst.Add(new Emp() { EmpID = 7, EmpName = "Nilesh", DeptName = "Computer", MobileNo = "958678768", Salary = 22000 });
            lst.Add(new Emp() { EmpID = 8, EmpName = "Nitin", DeptName = "Marketing", MobileNo = "9978678768", Salary = 89000 });
            lst.Add(new Emp() { EmpID = 9, EmpName = "Mahesh", DeptName = "Pruchase", MobileNo = "908678768", Salary = 670000 });
            lst.Add(new Emp() { EmpID = 10, EmpName = "Nilesh", DeptName = "Computer", MobileNo = "78678678768", Salary = 61000 });

            //var v = lst.First();
            //var v = lst.FirstOrDefault();
            //var v = lst.FirstOrDefault(p => p.DeptName == "Sales");
            //var v = lst.FirstOrDefault(p => p.DeptName == "Hr");

            //var v = lst.Single(p=>p.EmpID==5);

            //var v = lst.Single(p => p.EmpID == 15);
            //var v = lst.Single(p => p.DeptName == "Computer");
            //var v = lst.SingleOrDefault(p => p.EmpID == 5);
            //var v = lst.SingleOrDefault(p => p.EmpID == 15);
            var v = lst.SingleOrDefault(p => p.DeptName == "Computer");
            if (v != null)
                v.DispEmp();
            else
                Console.WriteLine("Emp Not Found");

            //var v = lst.OrderBy(p => p.EmpName);
            //var v = lst.OrderByDescending(p => p.EmpName);
            //var v = lst.OrderByDescending(p=>p.Salary).OrderBy(p=>p.EmpName);
            //var v = lst.Where(p => p.DeptName == "Computer" && p.Salary>50000);
            // var v = lst.Where(p => p.DeptName == "Computer").FirstOrDefault();
            // v.DispEmp();
            // var v = lst.Take(3);
            //var v = lst.OrderByDescending(p => p.Salary).Take(1);
            //var v = lst.Skip(8);
            //var v = lst.OrderByDescending(p => p.Salary).Skip(1).Take(1);
            //var v = lst.OrderByDescending(p => p.Salary).Skip(2).Take(1);
            // var v = (from t in lst
            //       select t).Where(p=>p.DeptName=="Computer").Take(2);

            //var v = (from t in lst.Where(p => p.DeptName == "Computer")
            //         select t).OrderByDescending(p => p.Salary).Take(1);

            //foreach (var temp in v)
            //{
            //    temp.DispEmp();
            //}
         
        }
    }
}

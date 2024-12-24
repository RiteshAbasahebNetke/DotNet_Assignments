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
            //int[] n = { 34, 45, 56, 6, 77, 12, 32, 8, 10, 9, 14 };

            //// var v=from t in n select t;
            ////var v = from t in n
            ////        where t > 20
            ////        select t;

            ////var v = from t in n
            ////        where t % 2 != 0
            ////        select t;

            //var v = from t in n
            //        where t > 20 && t % 2 == 0
            //        select t;

            //foreach (int temp in v)
            //{
            //    Console.WriteLine(temp);
            //}


            List<Emp> lst = new List<Emp>();
            lst.Add(new Emp() { EmpID = 2, EmpName = "Sunil", DeptName = "Computer", MobileNo = "99878768",Salary=45000});
            lst.Add(new Emp() { EmpID = 3, EmpName = "Amit", DeptName = "Sales", MobileNo = "98067878",Salary=10000});
            lst.Add(new Emp() { EmpID = 4, EmpName = "Ajit", DeptName = "Computer", MobileNo = "8908678768",Salary=12000});
            lst.Add(new Emp() { EmpID = 5, EmpName = "Sudhir", DeptName = "Puchase", MobileNo = "789678768",Salary=18000});
            lst.Add(new Emp() { EmpID = 6, EmpName = "Suresh", DeptName = "Sales", MobileNo = "898678768",Salary=34000});
            lst.Add(new Emp() { EmpID = 7, EmpName = "Nilesh", DeptName = "Computer", MobileNo = "958678768",Salary=22000});
            lst.Add(new Emp() { EmpID = 8, EmpName = "Nitin", DeptName = "Marketing", MobileNo = "9978678768",Salary=89000});
            lst.Add(new Emp() { EmpID = 9, EmpName = "Mahesh", DeptName = "Pruchase", MobileNo = "908678768",Salary=670000});
            lst.Add(new Emp() { EmpID = 10, EmpName = "Nilesh", DeptName = "Computer", MobileNo = "78678678768",Salary=61000});

            //var v = from t in lst
            //        where t.DeptName =="Computer"
            //        && t.Salary > 50000
            //        select t;

            //var v = from t in lst
            //        where t.DeptName =="Computer"
            //        select new
            //        {
            //           EName=t.EmpName,
            //           ESal=t.Salary,
            //           EDept=t.DeptName
            //        };

            //foreach (var temp in v)
            //{
            //    Console.WriteLine("Emp Name:" + temp.EmpName);
            //    Console.WriteLine("Salary :" + temp.Salary);
            //    Console.WriteLine("Dept Name:" + temp.DeptName);
            //}


            //foreach (var temp in v)
            //{
            //    Console.WriteLine("Emp Name:" + temp.EName);
            //    Console.WriteLine("Salary :" + temp.ESal);
            //    Console.WriteLine("Dept Name:" + temp.EDept);
            //}

            var v = from t in lst
                    orderby t.EmpName ascending,
                    t.Salary descending
                    select t;
            foreach (var temp in v)
            {
                temp.DispEmp();
            }
        }
    }
}

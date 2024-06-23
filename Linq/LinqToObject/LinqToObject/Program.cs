using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToObject
{
    class Emp
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string DeptName { get; set; }
        public string MobileNo { get; set; }
        public decimal Salary { get; set; }

        public void DispEmp()
        {
            Console.WriteLine("EmpId:" + EmpId);
            Console.WriteLine("EmpName:" + EmpName);
            Console.WriteLine("DeptName:" + DeptName);
            Console.WriteLine("MobileNo:" + MobileNo);
            Console.WriteLine("Salary:" + Salary);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Emp> e = new List<Emp>();
            e.Add(new Emp() { EmpId = 1, EmpName = "Raj", DeptName=  "Computer",   MobileNo=  "789654120", Salary=65200 });
            e.Add(new Emp() { EmpId = 2, EmpName = "Rajesh", DeptName = "Sales", MobileNo = "9632587410", Salary = 20000 });
            e.Add(new Emp() { EmpId = 3, EmpName = "Manish", DeptName = "Computer", MobileNo = "7845678120", Salary = 30000 });
            e.Add(new Emp() { EmpId = 4, EmpName = "Nitin", DeptName = "Purchase", MobileNo = "9125478301", Salary = 95200 });
            e.Add(new Emp() { EmpId = 5, EmpName = "Amit", DeptName = "Sales", MobileNo = "7654654120", Salary = 25000 });

            //var v = from m in e
            //        select m;

            //var v = from m in e
            //        where m.DeptName == "Sales"
            //        select m;

            //var v = from m in e
            //        where m.DeptName == "Computer" && m.Salary > 30000
            //        select m;

            var v = from m in e
                    orderby m.Salary descending
                    select m;

            foreach (var temp in v)
            {
                temp.DispEmp();
            }

            //var v = from m in e
            //        where m.DeptName=="Sales"
            //        select m;

            //foreach(var temp in v)
            //{
            //    Console.WriteLine("EmpName:" + temp.EmpName);
            //    Console.WriteLine("DeptName:" + temp.DeptName);
            //}



            // int[] n = { 21, 36, 85, 96, 3, 10, 5 };

            //var v = from m in n
            //        select m;

            //var v = from m in n
            //        where m % 2 == 0
            //        select m;

            //var v = from m in n
            //        where m > 50 && m % 2 == 0
            //        select m;

            //foreach(var temp in v)
            //{
            //    Console.WriteLine(temp);
            //}
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Methods
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
            Console.WriteLine("EmpId:" + this.EmpId);
            Console.WriteLine("EmpName:" + this.EmpName);
            Console.WriteLine("DeptName:" + this.DeptName);
            Console.WriteLine("MobileNo:" + this.MobileNo);
            Console.WriteLine("Salary:" + this.Salary);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Emp> el = new List<Emp>();
            el.Add(new Emp() { EmpId = 1, EmpName = "Raj", DeptName = "HR", MobileNo = "4565465561", Salary = 25000 });
            el.Add(new Emp() { EmpId = 2, EmpName = "Suresh", DeptName = "Purchase", MobileNo = "4520465561", Salary = 30000 });
            el.Add(new Emp() { EmpId = 3, EmpName = "Ram", DeptName = "IT", MobileNo = "4565465596", Salary = 35000 });
            el.Add(new Emp() { EmpId = 4, EmpName = "Sham", DeptName = "Sales", MobileNo = "4565466661", Salary = 45000 });
            el.Add(new Emp() { EmpId = 6, EmpName = "Sunita", DeptName = "Sales", MobileNo = "4565467761", Salary = 60000 });
            el.Add(new Emp() { EmpId = 7, EmpName = "Monika", DeptName = "IT", MobileNo = "4569635561", Salary = 28000 });
            el.Add(new Emp() { EmpId = 8, EmpName = "Monali", DeptName = "HR", MobileNo = "45555545561", Salary = 22000 });
            el.Add(new Emp() { EmpId = 9, EmpName = "Onkar", DeptName = "Purchase", MobileNo = "4565465555", Salary = 20000 });
            el.Add(new Emp() { EmpId = 10, EmpName = "Nilesh", DeptName = "HR", MobileNo = "4566465561", Salary = 25000 });

            // var v=el.First();
            //var v = el.FirstOrDefault();
            //var v = el.FirstOrDefault(p => p.DeptName == "IT");

            //var v = el.Single(p => p.EmpName == "Ram");
            //var v = el.Single(p => p.EmpId == 6);
            //var v = el.SingleOrDefault(p => p.DeptName == "Sales"); in this section  if there are more than one parameter of same name then it shows unexception handling
            //var v = el.SingleOrDefault(p => p.EmpName == "Ram");
            //var v = el.SingleOrDefault(p => p.DeptName == "Computer");
            //if (v != null)
            //    v.DispEmp();
            //else
            //    Console.WriteLine("Emp Not Found");

            //var v = el.OrderBy(p => p.Salary);
            //var v = el.OrderByDescending(p => p.EmpName);
            //var v = el.OrderByDescending(p => p.Salary).OrderBy(p => p.EmpName);

            //foreach(var temp in v)
            //{
            //    temp.DispEmp();
            //}


            //var v = el.Where(p => p.DeptName == "HR").FirstOrDefault();
            //v.DispEmp();

            //var v = el.Take(2);
            //var v = el.Skip(2).Take(1);

            //foreach(var temp in v)
            //{
            //    temp.DispEmp();
            //} 

            //var v = el.Skip(4).FirstOrDefault();
            //v.DispEmp();

            //var v = el.OrderBy(p => p.Salary).Skip(2);
            var v = el.OrderByDescending(p => p.EmpName).Take(1);

            foreach (var temp in v)
            {
                temp.DispEmp();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LinqToObject
{
    class Emp
    {
        public Int64 EmpID { get; set; }
        public string EmpName { get; set; }
        public string DeptName { get; set; }
        public double Salary { get; set; }

        public void DispEmp()
        {
            Console.WriteLine("EmpID:" + this.EmpID);
            Console.WriteLine("EmpName:" + this.EmpName);
            Console.WriteLine("DeptName:"+ this.DeptName);
            Console.WriteLine("Salary:"+ this.Salary);
            Console.WriteLine();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Emp> el = new List<Emp>();
            el.Add(new Emp() { EmpID = 1, EmpName = "Satish", DeptName = "Sales", Salary = 25000 });
            el.Add(new Emp() { EmpID = 2, EmpName = "Suresh", DeptName = "Computer", Salary = 20000 });
            el.Add(new Emp() { EmpID = 3, EmpName = "Nilesh", DeptName = "Sales", Salary = 45000 });
            el.Add(new Emp() { EmpID = 4, EmpName = "Raj", DeptName = "Sales", Salary = 70000 });
            el.Add(new Emp() { EmpID = 5, EmpName = "Sham", DeptName = "Computer", Salary = 35000 });

            //var v = from m in el select m;

            //var v = from m in el where m.DeptName == "Sales" select m;

            //var v = from m in el where m.DeptName == "Computer" && m.Salary > 30000 select m;

            //var v = from m in el orderby m.Salary select m;

            //foreach (var temp in v)
            //{
            //    temp.DispEmp();
            //}

            var v = from m in el orderby m.Salary descending select m;
            foreach(var temp in v)
            {
                Console.WriteLine("EmpName:" + temp.EmpName);
                Console.WriteLine("Salary:"+ temp.Salary);
            }
            
        }
    }
}

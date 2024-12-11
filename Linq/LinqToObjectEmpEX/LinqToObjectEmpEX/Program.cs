using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToObjectEmpEX
{
    class Emp
    {
        public Int64 EmpID { get; set; }
        public string EmpName { get; set; }
        public string DeptName { get; set; }
        public decimal Salary { get; set; }

        public void DispEmp()
        {
            Console.WriteLine("EmpID:" + this.EmpID);
            Console.WriteLine("Emp Name:"+ EmpName);
            Console.WriteLine("Dept Name:"+ this.DeptName);
            Console.WriteLine("Salary:"+ this.Salary);
            Console.WriteLine();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Emp> el=new List<Emp>();
            el.Add(new Emp() { EmpID = 1, EmpName = "Rajesh", DeptName = "Sales", Salary = 56000 });
            el.Add(new Emp() { EmpID = 2, EmpName = "Sham", DeptName = "Purchase", Salary = 34000 });
            el.Add(new Emp() { EmpID = 3, EmpName = "Supriya", DeptName = "IT", Salary = 70000 });
            el.Add(new Emp() { EmpID = 4, EmpName = "Monali", DeptName = "IT", Salary = 22000 });
            el.Add(new Emp() { EmpID = 5, EmpName = "Sujit", DeptName = "Purchase", Salary = 20000 });
            el.Add(new Emp() { EmpID = 6, EmpName = "Ajit", DeptName = "Sales", Salary = 67000 });
            el.Add(new Emp() { EmpID = 7, EmpName = "Sangita", DeptName = "Sales", Salary = 56000 });

            //var v = from m in el where m.DeptName == "Sales" && m.Salary > 50000 select m;

            //var v = from m in el orderby m.EmpName descending select m;

            //var v = from m in el where m.EmpName.Length > 6 select m;

            var v = from m in el where m.EmpName.StartsWith("Mo") select m;

            foreach(var temp in v)
            {
                temp.DispEmp();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodExample
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
            Console.WriteLine("Emp Name:" + this.EmpName);
            Console.WriteLine("Dept Name:"+ this.DeptName);
            Console.WriteLine("Salary:"+ this.Salary);
            Console.WriteLine();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Emp> el = new List<Emp>();
            el.Add(new Emp() { EmpID = 1, EmpName = "Sayali", DeptName = "IT", Salary = 45000 });
            el.Add(new Emp() { EmpID = 2, EmpName = "Manoj", DeptName = "Purchase", Salary = 40000 });
            el.Add(new Emp() { EmpID = 3, EmpName = "Priya", DeptName = "Sales", Salary = 67000 });
            el.Add(new Emp() { EmpID = 4, EmpName = "Manisha", DeptName = "IT", Salary = 30000 });
            el.Add(new Emp() { EmpID = 5, EmpName = "Manish", DeptName = "Purchase", Salary = 50000 });
            el.Add(new Emp() { EmpID = 6, EmpName = "Soham", DeptName = "Sales", Salary = 78000 });
            el.Add(new Emp() { EmpID = 7, EmpName = "Suresh", DeptName = "IT", Salary = 43000 });

            //var v = el.OrderByDescending(p => p.Salary);

            //var v = el.Skip(2);

            //var v = el.Take(3);

            /*var v = el.Skip(3).Take(2);

            foreach(var temp in v)
            {
                temp.DispEmp();
            }*/

            var v = from m in el
                    group m by m.DeptName into m
                    select new
                    {
                        DName = m.Key,
                        MinSalary = m.Min(p => p.Salary),
                        MaxSalary = m.Max(p => p.Salary),
                        AverageSalary = m.Average(p => p.Salary)
                    };

            foreach(var temp in v)
            {
                Console.WriteLine("DeptName:"+ temp.DName + "MinSalary:"+ temp.MinSalary + 
                    "MaxSalary:"+ temp.MaxSalary + "Average Salary:"+ temp.AverageSalary);
            }
        }
    }
}

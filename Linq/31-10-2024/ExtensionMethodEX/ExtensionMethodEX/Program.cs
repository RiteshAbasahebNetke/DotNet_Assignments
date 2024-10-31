using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodEX
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
            Console.WriteLine("EmpName:"+ this.EmpName);
            Console.WriteLine("MfgName:" + this.DeptName);
            Console.WriteLine("Price:" + this.Salary);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Emp> e=new List<Emp>();
            e.Add(new Emp() { EmpID = 1, EmpName = "Sujit", DeptName = "Sales", Salary = 34000 });
            e.Add(new Emp() { EmpID = 2, EmpName = "Ramesh", DeptName = "Computer", Salary = 45000 });
            e.Add(new Emp() { EmpID = 3, EmpName = "Akash", DeptName = "Computer", Salary = 12000 });
            e.Add(new Emp() { EmpID = 4, EmpName = "Manohar", DeptName = "Sales", Salary = 56000 });
            e.Add(new Emp() { EmpID = 5, EmpName = "Amol", DeptName = "Sales", Salary = 44000 });

            //var v = e.OrderByDescending(p => p.Salary);

            //var v = e.Skip(3);

            //foreach (var temp in v)
            //{
            //    temp.DispEmp();
            //}

            var v = from m in e
                    group m by m.DeptName into m
                    select new
                    {
                        DName = m.Key,
                        MinSalry = m.Min(p => p.Salary),
                        MaxSalary = m.Max(p => p.Salary),
                        TotalEmp = m.Count()
                    };

            foreach(var temp in v)
            {
                Console.WriteLine("DeptName:" + temp.DName + "MinSalary:" + temp.MinSalry + "MaxSalary:" + temp.MaxSalary
                    + "TotalEmp:" + temp.TotalEmp);
            }
        }
    }
}

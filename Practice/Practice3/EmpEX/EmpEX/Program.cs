using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpEX
{
    class Emp
    {
        public int EmpID;
        public string EmpName;
        public string DeptName;
        public decimal Salary;

        public void AddEmp(int ei,string en,string dn,decimal s)
        {
            this.EmpID = ei;
            this.EmpName = en;
            this.DeptName = dn;
            this.Salary = s;
        }
        public void DispEmp()
        {
            Console.WriteLine("EmpID:" + this.EmpID);
            Console.WriteLine("Emp Name:" + this.EmpName);
            Console.WriteLine("Dept Name:"+ this.DeptName);
            Console.WriteLine("Salary:"+ this.Salary);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Emp e = new Emp();
            int ei;
            string dn, en;
            decimal s;

            Console.Write("Enter EmpID:");
            ei = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter EmpName:");
            en=Console.ReadLine();

            Console.Write("Enter DeptName:");
            dn = Console.ReadLine();

            Console.Write("Enter Salary:");
            s = Convert.ToInt64(Console.ReadLine());

            e.AddEmp(ei,en,dn,s);
            e.DispEmp();
        }
    }
}

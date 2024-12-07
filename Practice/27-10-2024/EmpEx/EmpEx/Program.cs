using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpEx
{
    public class Emp
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
            Console.WriteLine("Emp Name:"+ this.EmpName);
            Console.WriteLine("Dept Name:" + this.DeptName);
            Console.WriteLine("Salary:"+ this.Salary);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Emp e=new Emp();
            e.AddEmp(1, "Rajesh", "Sales", 78000);
            e.DispEmp();

            Emp e1 = new Emp();
            e1.AddEmp(2, "Sham", "Computer", 45000);
            e1.DispEmp();
        }
    }
}

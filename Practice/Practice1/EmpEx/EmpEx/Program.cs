using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpEx
{
    class Emp
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public string DeptName { get; set; }
        public double Salary { get; set; }

        public void AddEmp(int eid,string en,string dn,double s)
        {
            this.EmpID = eid;
            this.EmpName = en;
            this.DeptName = dn;
            this.Salary = s;
        }

        public void DispEmp()
        {
            Console.WriteLine("EmpID:"+ this.EmpID);
            Console.WriteLine("Emp Name:" + this.EmpName);
            Console.WriteLine("Dept Name:" + this.DeptName);
            Console.WriteLine("Salary:" + this.Salary);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Emp e=new Emp();
            int eid;
            string en, dn;
            double s;

            Console.Write("Enter EmpID:");
            eid = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter EmpName:");
            en= Console.ReadLine();
            Console.Write("Enter DeptName:");
            dn= Console.ReadLine();
            Console.Write("Enter Salary:");
            s=Convert.ToDouble(Console.ReadLine());

            e.AddEmp(eid,en,dn,s);
            e.DispEmp();
        }
    }
}

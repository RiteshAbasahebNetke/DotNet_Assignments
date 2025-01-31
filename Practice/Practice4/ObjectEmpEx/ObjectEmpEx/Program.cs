using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectEmpEx
{
    class Emp
    {
        public int EmpID;
        public string EmpName;
        public string DeptName;
        public double Salary;

        public void AddEmp(int id,string en,string dn,double s)
        {
            this.EmpID = id;
            this.EmpName = en;
            this.DeptName = dn;
            this.Salary = s;
        }
        public void DispEmp()
        {
            Console.WriteLine("EmpID is:"+ this.EmpID);
            Console.WriteLine("Emp Name is:" + this.EmpName);
            Console.WriteLine("Dept Name is:" + this.DeptName);
            Console.WriteLine("Salary is:"+ this.Salary);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Emp e=new Emp();
            int id;
            string en, dn;
            double s;

                Console.Write("Enter EmpID:");
                id=Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter EmpName:");
                en = Console.ReadLine();

                Console.Write("Enter DeptName:");
                dn= Console.ReadLine();

                Console.Write("Enter Salary:");
                s=Convert.ToDouble(Console.ReadLine());

                e.AddEmp(id, en, dn, s);
                e.DispEmp();
           
        }
    }
}

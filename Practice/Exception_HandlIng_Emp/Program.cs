using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_HandlIng_Emp
{
    class salary : Exception
    {
        private string ExMessage;
        public salary (string exMessage)
        {
            ExMessage = exMessage;
        }
        public void dispsalaryException()
        {
            Console.WriteLine("############ Salary exception occured #############");
        }
    }
    class Emp
    {
        private int empid;
        private string empname;
        private string deptname;
        private int salary;

        public void addemp(int ed, string en, string dn, int s)
        {
            if(s<10000 && dn == "Computer")
            {
                throw new salary("Salary can not be less than 10000");
            }
            this.empid = ed;
            this.empname = en;
            this.deptname = dn;
            this.salary = s;
        }
        public void dispemp()
        {
            Console.WriteLine("Emp ID:" + this.empid);
            Console.WriteLine("EmpName:" + this.empname);
            Console.WriteLine("DeptName:" + this.deptname);
            Console.WriteLine("Salary:" + this.salary);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Emp e = new Emp();
            try
            {
                e.addemp(1, "Rajesh", "Computer", 1000);
                e.dispemp();
            }
            catch (salary sx)
            {
                sx.dispsalaryException();
            }
        }
    }
}

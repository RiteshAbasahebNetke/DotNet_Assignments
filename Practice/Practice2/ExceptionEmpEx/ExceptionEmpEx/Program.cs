using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionEmpEx
{
    class Salary:Exception
    {
        private string ExMessage;
        public Salary(string exMessage)
        {
            ExMessage = exMessage;
        }  
        
        public void dispSalaryException()
        {
            Console.WriteLine("Salary Exception Occured...!");
            Console.WriteLine("Message:"+ this.ExMessage);
        }
    }
    class Emp
    {
        private int EmpID;
        private string EmpName;
        private string DeptName;
        private double Salary;

        public void AddEmp(int ei,string en,string dn,double s)
        {
            if (s < 10000 && dn == "Computer")
            {
                throw new Salary("Salary can not be less than 10000");
            }
            this.EmpID = ei;
            this.EmpName = en;
            this.DeptName = dn;
            this.Salary = s;
        }
        public void DispEmp()
        {
            Console.WriteLine("EmpID:" + this.EmpID);
            Console.WriteLine("EmpName:"+ this.EmpName);
            Console.WriteLine("DeptName:" + this.DeptName);
            Console.WriteLine("Salary:"+ this.Salary);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Emp e = new Emp();
            try
            {
                e.AddEmp(1, "Raaj", "Sales", 12000);
                e.DispEmp();
            }
            catch(Salary s)
            {
                s.dispSalaryException();
            }
        }
    }
}

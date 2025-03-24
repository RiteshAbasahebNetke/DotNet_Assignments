using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSetExample
{
    class Emp
    {
        private int EmpID;
        private string EmpName;
        private string DeptName;
        private double Salary;

        public string proDeptName
        {
            get { return DeptName; }
        }
        public double proSalary
        {
            get
            { return Salary; }
        }
        public Emp(int ei, string en, string d,double s)
        {
            this.EmpID = ei;
            this.EmpName = en;
            this.DeptName = d;
            this.Salary = s;
        }
        public void DispEmp()
        {
            Console.WriteLine("EmpID:"+ this.EmpID);
            Console.WriteLine("EmpName:"+ this.EmpName);
            Console.WriteLine("DeptName:"+ this.DeptName);
            Console.WriteLine("Salary:"+ this.Salary);
        }
    }
        internal class Program
        {
            static void Main(string[] args)
            {
               List<Emp> el= new List<Emp>();
            int ei;
            string en, dn;
            double s;

            for(int i=0; i<3;  i++)
            {
                Console.Write("Enter EmpID:");
                ei=Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter EmpName:");
                en=Console.ReadLine();
                Console.Write("Enter DeptName:");
                dn=Console.ReadLine();
                Console.Write("Enter Salary:");
                s=Convert.ToDouble(Console.ReadLine());

                el.Add(new Emp(ei, en, dn, s));
            }
            Console.WriteLine("****************EMP Details***************");
            foreach(var temp in el)
            {
                if(temp.proDeptName=="Sales" && temp.proSalary>15000)
                {
                    temp.DispEmp();
                }
            }
            }
        }
    
}

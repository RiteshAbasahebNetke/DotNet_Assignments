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
        public string propdeptname
        {
            get { return DeptName; }
        }
        public double propsalary
        {
            get { return Salary; }
        }

        public Emp(int eid,string en,string dn,double s)
        {
            this.EmpID = eid;
            this.EmpName = en;
            this.DeptName = dn;
            this.Salary = s;
        }
        public void dispEmp()
        {
            Console.WriteLine("EmpID:" + this.EmpID);
            Console.WriteLine("EmpName:"+ this.EmpName);
            Console.WriteLine("DeptName:" + this.DeptName);
            Console.WriteLine("Salary:" + this.Salary);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Emp> el = new List<Emp>();
            int eid;
            string en, dn;
            double s;

            for(int i=0;i<3;i++)
            {
                Console.Write("Enter EmpID:");
                eid=Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter EmpName:");
                en = Console.ReadLine();

                Console.Write("Enter DeptName:");
                dn = Console.ReadLine();

                Console.Write("Enter Salary:");
                s=Convert.ToDouble(Console.ReadLine());

                el.Add(new Emp(eid,en,dn,s));
            }
            Console.WriteLine("***************Emp Details:******************");
            foreach(Emp temp in el)
            {
                if(temp.propsalary>15000 && temp.propdeptname=="Sales")
                {
                    temp.dispEmp();
                }
            }
        }
    }
}

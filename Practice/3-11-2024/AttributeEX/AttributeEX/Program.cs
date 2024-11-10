using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeEX
{
    class ProInfo:Attribute
    {
        private string ContractorName;
        public string Company { get; set; }
        public ProInfo(string cn) { this.ContractorName = cn; }

    }
    [ProInfo("ABC",Company ="xyz")]

    class Project
    {
        public int ProjectID;
        public string ProjectName;
        public string CityName;
        public double Budget;
        [ProInfo("ABC", Company = "xyz")]
        public void addProject(int pid,string pn,string cn,double b)
        {
            this.ProjectID = pid;
            this.ProjectName = pn;
            this.CityName = cn;
            this.Budget = b;

        }
        [ProInfo("ABC", Company = "xyz")]
        public void dispProject()
        {
            Console.WriteLine("ProjectID:"+ this.ProjectID);
            Console.WriteLine("Project Name:"+ this.ProjectName);
            Console.WriteLine("City Name:" + this.CityName);
            Console.WriteLine("Budget:" + this.Budget);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Project p = new Project();
            p.addProject(1, "Road", "Nagar", 40000.1);
            p.dispProject();
        }
    }
}

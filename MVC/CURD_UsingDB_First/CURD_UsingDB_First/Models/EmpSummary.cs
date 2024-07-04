using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CURD_UsingDB_First.Models
{
    public class EmpSummary
    {
        public string DeptName { get; set; }
        public decimal? TotalSalary { get; set; }
        public decimal? MinSalary { get; set; }
        public decimal? MaxSalary { get; set; }
        public decimal? AvgSalary { get; set; }
        public int CountOfEmp { get; set; }

    }
}
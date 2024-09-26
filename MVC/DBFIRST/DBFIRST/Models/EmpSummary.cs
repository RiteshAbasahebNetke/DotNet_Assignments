using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DBFIRST.Models
{
    public class EmpSummary
    {
        public string DeptName { get; set; }
        public decimal TotalSal { get; set; }
        public decimal MinSal { get; set; }
        public decimal MaxSal { get; set; }
        public decimal AvgSal { get; set; }
        public int CountOfEmps { get; set; }
    }
}
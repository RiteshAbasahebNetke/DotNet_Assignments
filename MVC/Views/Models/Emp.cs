using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Views.Models
{
    public class Emp
    {
        public Int64 EmpId { get; set; }

        public string EmpName { get; set; }
        
        public string DeptName { get; set; }

        public string MobileNo { get; set; }

        public decimal Salary { get; set; }

        public Emp()
        {
            this.EmpId = 121;
            this.EmpName = "Raj";
            this.DeptName = "Sales";
            this.MobileNo = "895647123";
            this.Salary = 85413;
        }

    }
}
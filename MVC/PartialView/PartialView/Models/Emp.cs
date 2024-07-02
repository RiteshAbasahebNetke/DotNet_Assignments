using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PartialView.Models
{
    public class Emp
    {
        public Int64 EmpID { get; set; }
        public string EmpName { get; set; }
        public string DeptName { get; set; }
        public string MobileNo { get; set; }
        public decimal Salary { get; set; }

        public Emp()
        {
            this.EmpID = 12;
            this.EmpName = "Suresh";
            this.DeptName = "Computer";
            this.MobileNo = "9324823213";
            this.Salary = 69000;
        }
    }
}
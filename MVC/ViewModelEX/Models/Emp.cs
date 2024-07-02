using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ViewModelEX.Models
{
    public class Emp
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string DeptName { get; set; }
        public string EmailId { get; set; }
        public decimal Salary { get; set; }

        public Emp()
        {
            this.EmpId = 12;
            this.EmpName = "Rajesh";
            this.DeptName = "Purchase";
            this.EmailId = "raj@hotmail.com";
            this.Salary = 96200;
        }
    }
}
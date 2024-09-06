using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.UI;

namespace ActionToView.Models
{
    public class Model
    {
        public Int64 EmpId { get; set; }
        public string EmpName { get; set; }
        public string DeptName { get; set; }
        public string EmailId { get; set; }
        public decimal Salary { get; set; }

        public Model()
        {
            this.EmpId = 121;
            this.EmpName = "Raj";
            this.DeptName = "HR";
            this.EmailId = "raj@hotmail.com";
            this.Salary = 85203;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ViewModelEX.Models
{
    public class ProCusEmpVM
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string CustomerName { get; set; }
        public int Age { get; set; }
        public string MobileNo { get; set; }
        public int EmpId { get; set; }
        public string DeptName { get; set; }
        public decimal Salary { get; set; }
    }
}
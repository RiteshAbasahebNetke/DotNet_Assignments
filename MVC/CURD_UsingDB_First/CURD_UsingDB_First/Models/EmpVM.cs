using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CURD_UsingDB_First.Models
{
    public class EmpVM
    {
        public Int64 EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmailId { get; set; }
        public decimal? Salary { get; set; }
        public  Int64 DeptId { get; set; }
        public string DeptName { get; set; }
        public string AreaName { get; set; }
    }
}
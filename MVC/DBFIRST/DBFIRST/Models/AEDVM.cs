using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DBFIRST.Models
{
    public class AEDVM
    {
        public Int64 EmpId { get; set; }
        public string EmpName { get; set; }
        public Int64 DeptId { get; set; }
        public string DeptName { get; set; }
    }
}
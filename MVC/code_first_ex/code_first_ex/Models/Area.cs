using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace code_first_ex.Models
{
    public class Area
    {
        public Int64 AreaId { get; set; }
        public string AreaName { get; set; }
        public List<Dept> Depts { get; set; }
        public Area EmpArea { get; set; }
    }
}
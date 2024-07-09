using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace code_first_ex.Models
{
    [Table("DeptTbl")]
    public class Dept
    {
        [Key]
        public Int64 DID { get; set; }
        public string DeptName { get; set; }
        public List<Emp> Emps { get; set; }
    }
}
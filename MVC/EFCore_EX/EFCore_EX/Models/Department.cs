using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCore_EX.Models
{
    [Table("DeptTbl")]
    public class Department
    {
        [Key]
        public Int64 DeptID { get; set; }
        public string DeptName { get; set; }
        public virtual List<Emp> Emps { get; set; }
    }
}

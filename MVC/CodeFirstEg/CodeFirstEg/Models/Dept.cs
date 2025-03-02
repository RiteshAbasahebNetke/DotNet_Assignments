using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CodeFirstEg.Models
{
    [Table("DeptTbl")]
    public class Dept
    {
        [Key]
        public Int64 DeptID {  get; set; }
        public string DeptName {  get; set; }
        public virtual List<Emp> Emps { get; set; }
    }
}
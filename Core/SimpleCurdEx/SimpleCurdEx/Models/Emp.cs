﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimpleCurdEx.Models
{
    [Table("EmpTbl")]
    public class Emp
    {
        [Key]
        public Int64 EmpID {  get; set; }
        public string EmpName {  get; set; }
        public string EmailID {  get; set; }
        public double Price {  get; set; }

        [ForeignKey("Dept")]
        public Int64 DeptID {  get; set; }
        public virtual Dept Dept {  get; set; }
    }
}

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repo_Curd.Models
{
    [Table("EmpTbl")]
    public class Emp
    {
        [Key]
        public Int64 EmpID { get; set; }
        [Required(ErrorMessage ="Please enter the EmpName")]
        public string EmpName { get; set; }
        [Required(ErrorMessage ="Please enter the EmailID")]
        [EmailAddress(ErrorMessage ="Please enter proper format of email address")]
        public string EmailID { get; set; }
        [Required(ErrorMessage ="Please enter cityname")]
        public string Address { get; set; }
        [Required(ErrorMessage ="Please enter the salary")]
        [Range (12000,100000)]
        public decimal Salary { get; set; }

        [ForeignKey("Department")]
        public Int64 DeptID { get; set; }
        public virtual Department Department { get; set; }
    }
}

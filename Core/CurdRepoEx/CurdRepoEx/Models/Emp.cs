using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CurdRepoEx.Models
{
    [Table("EmpTbl")]
    public class Emp
    {
        [Key]
        public Int64 EmpID { get; set; }
        [Required(ErrorMessage ="Please Enter EmpName")]
        public string EmpName { get; set; }
        [Required(ErrorMessage ="Please enter email id")]
        [EmailAddress(ErrorMessage ="Please enter vaild email id")]
        public string EmailID { get; set; }
        [Required(ErrorMessage ="Please enter Salary")]
        [Range(10000 ,100000)]
        public decimal Salary { get; set; }

        [ForeignKey("Dept")]
        public Int64 DeptID { get; set; }
        public virtual Dept Dept { get; set; }
    }
}

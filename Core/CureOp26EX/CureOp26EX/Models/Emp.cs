using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CureOp26EX.Models
{
    [Table("EmpTbl")]
    public class Emp
    {
        [Key]
        public Int64 EmpID { get; set; }
        public string EmpName { get; set; }
        public string EmailID { get; set; }
        public decimal Salary { get; set; }

        [ForeignKey("Depts")]
        public Int64 DeptID { get; set; }
        public virtual Dept Depts { get; set; }
    }
}

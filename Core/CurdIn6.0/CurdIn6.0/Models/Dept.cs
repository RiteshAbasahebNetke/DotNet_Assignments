using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CurdIn6._0.Models
{
    [Table("DeptTbl")]
    public class Dept
    {
        [Key]
        public Int64 DeptID { get; set; }
        public string DeptName { get; set; }
        public virtual List<Emp> Emps { get; set; }
    }
}

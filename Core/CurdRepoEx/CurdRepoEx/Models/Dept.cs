using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CurdRepoEx.Models
{
    [Table("DeptTbl")]
    public class Dept
    {
        [Key]
        public Int64 DeptID { get; set; }
        [Required(ErrorMessage ="Please select Dept Name")]
        public string DeptName { get; set; }
        public virtual List<Emp> Emps { get; set; }
    }
}

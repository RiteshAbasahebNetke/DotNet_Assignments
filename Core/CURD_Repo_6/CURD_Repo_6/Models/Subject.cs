using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CURD_Repo_6.Models
{
    [Table("SubTbl")]
    public class Subject
    {
        [Key]
        public Int64 SubjectID { get; set; }
        [Required(ErrorMessage ="Please select the SubjectName")]
        public string SubjectName { get; set; }
        public virtual List<Book> Books { get; set; }
    }
}

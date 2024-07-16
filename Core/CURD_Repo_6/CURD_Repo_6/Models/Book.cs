using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CURD_Repo_6.Models
{
    [Table("BookTbl")]
    public class Book
    {
        [Key]
        public Int64 BookID { get; set; }
        [Required(ErrorMessage ="BookName is required")]
        public string BookName { get; set; }
        [Required(ErrorMessage ="AuthorName is mandatory")]
        public string AuthorName { get; set; }
        [Required(ErrorMessage ="Please enter the price")]
        public decimal Price { get; set; }

        [ForeignKey("Subject")]
        public Int64 SubjectID { get; set; }
        public virtual Subject Subject { get; set; }
    }
}

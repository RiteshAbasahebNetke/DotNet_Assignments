using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CurdOperationEx.Models
{
    [Table("CategoryTbl")]
    public class Category
    {
        [Key]
        public Int64 CategoryID { get; set; }
        [Required(ErrorMessage ="Please enter Category")]
        public string CategoryName { get; set; }    
        public virtual List<Product> Products { get; set; }
    }
}

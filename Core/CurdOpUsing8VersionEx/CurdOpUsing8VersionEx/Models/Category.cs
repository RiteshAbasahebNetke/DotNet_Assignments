using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CurdOpUsing8VersionEx.Models
{
    [Table("CategoryTbl")]
    public class Category
    {
        [Key]
        public Int64 CategoryID {  get; set; }
        public string CategoryName { get; set; }
        public virtual List<Product> Products { get; set; }
    }
}

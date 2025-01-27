using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AssignmentCoreEx.Models
{
    [Table("ProCatTbl")]
    public class ProductCategory
    {
        [Key]
        public Int64 ProductCategoryID {  get; set; }
        public string CategoryName { get; set; }
        public virtual List<Product> Products { get; set; }
    }
}

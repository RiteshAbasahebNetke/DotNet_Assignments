using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace curdcoreEx.Models
{
    [Table("CategoryTbl")]
    public class Category
    {
        [Key]
        public Int64 CategoryID { get; set; }
        public string CategoryName { get; set; }
    }
}

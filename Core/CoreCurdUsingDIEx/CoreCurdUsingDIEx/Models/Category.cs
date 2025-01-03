using System.ComponentModel.DataAnnotations;

namespace CoreCurdUsingDIEx.Models
{

    public class Category
    {
        [Key]
        public Int64 CategoryID {  get; set; }
        public string CategoryName { get; set; }
        public virtual List<Product> Products { get; set; }
    }
}

using EF_Core_Curd.ENum;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Core_Curd.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public Int64 ProductID { get; set; }
        [Required(ErrorMessage = "Please Enter ProductName")]
        public string ProductName { get; set; }
        [Required(ErrorMessage = "Please Enter MfgName")]
        public string MfgName { get; set; }
        [Required(ErrorMessage = "Please select ProductColor")]
        public ColorEnum ProductColor { get; set; }
        [Required(ErrorMessage = "Please Enter Price")]
        [Range (1000,9000)]
        public decimal Price { get; set; }

        [ForeignKey("ProductCategory")]
        [Required(ErrorMessage = "Product Category is mandatory")]
        public Int64 ProductCategoryID { get; set; }
        public virtual ProductCategory ProductCategory { get; set; }
    }
}

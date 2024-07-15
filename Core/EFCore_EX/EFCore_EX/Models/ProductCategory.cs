using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCore_EX.Models
{
    [Table ("ProductCat")]
    public class ProductCategory
    {
        [Key]
        public Int64 ProductCategoryID { get; set; }
        public string ProductCategoryName { get; set; }
        public virtual List<Product> Products { get; set; }
    }
}

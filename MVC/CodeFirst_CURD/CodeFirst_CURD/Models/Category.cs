using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CodeFirst_CURD.Models
{

    [Table("CategoryTbl")]
    public class Category
    {
        [Key]
        public Int64 CategoryId { get; set; }
        public string CategoryName { get; set; }
        public virtual List<Product> Products { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AssignmentCoreEx.Models
{
    [Table("ProductTbl")]
    public class Product
    {
        [Key]
        public Int64 ProductID {  get; set; }
        public string ProductName { get; set; }
        public string ProductDesc {  get; set; }
        public double Price {  get; set; }

        [ForeignKey("ProductCategory")]
        public Int64 ProductCategoryID {  get; set; }
        public virtual ProductCategory ProductCategory { get; set; }

        [ForeignKey("Color")]
        public Int64 ColorID {  get; set; }
        public virtual Color Color { get; set; }

        [ForeignKey("Mfg")]
        public Int64 MfgID {  get; set; }
        public virtual Mfg Mfg { get; set; }
    }
}

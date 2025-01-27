using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AssignmentCoreEx.Models
{
    [Table("MfgTbl")]
    public class Mfg
    {
        [Key]
        public Int64 MfgID {  get; set; }
        public string MfgName { get; set; } 
        public string Address {  get; set; }
        public string EmailID {  get; set; }
        public string MobileNo {  get; set; }
        public virtual List<Product> Products { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core_Repo_Test.Models
{
    [Table("CityTbl")]
    public class City
    {
        [Key]
        public Int64 CityID {  get; set; }  
        public string CityName { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("CityTbl")]
    public class City
    {
        [Key]
        public Int64 CityID { get; set; }
        public string CityName { get; set; }
        [ForeignKey("States")]
        public Int64 StateID { get; set; }
        public virtual State States { get; set; }
        public virtual List<Area> Area { get; set; }
        public virtual List<Clinic> Clinic { get; set; }    
    }
}

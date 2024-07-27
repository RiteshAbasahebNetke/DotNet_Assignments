using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("SpecilityTbl")]
    public class Specility
    {
        [Key]
        public Int64 SpecilityID { get; set; }
        public string SpecilityName { get; set; }
        public virtual List<DoctorSpeciality> DoctorSpecialities { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("ClinicFacilityTbl")]
    public class ClinicFacility
    {
        [Key]
        public Int64 ClinicFacilityID { get; set; }
        public string FacilityName { get; set; }
        [ForeignKey("Clinic")]
        public Int64 ClinicID { get; set; }
        public virtual Clinic Clinic { get; set; }
    }
}

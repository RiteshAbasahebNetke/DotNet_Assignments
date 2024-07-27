using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("OPDSessionTbl")]
    public class OPDSession
    {
        [Key]
        public Int64 OpdSessionID { get; set; }
        public string SessionName { get; set; }
        [ForeignKey("Clinic")]
        public Int64 ClinicID { get; set; }
        public virtual Clinic Clinic { get; set; }
        public virtual List<DoctorClinicSession> DoctorClinicSessions { get; set; }
    }
}

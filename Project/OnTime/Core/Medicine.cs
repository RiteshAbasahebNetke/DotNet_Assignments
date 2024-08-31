using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("MedicineTbl")]
    public class Medicine
    {
        [Key]
        public Int64 MedicineID { get; set; }
        public string MedicineName { get; set; }    
        public string MfgName { get; set; }
        public string GenericName { get; set; }
        public virtual List<AppointmentPrescriptionDetails> AppointmentPrescriptionDetails { get; set; }
    }
}

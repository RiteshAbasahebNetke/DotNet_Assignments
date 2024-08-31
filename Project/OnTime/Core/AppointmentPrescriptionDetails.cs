using Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("AppointmentPrescriptionDetailsTbl")]
    public class AppointmentPrescriptionDetails
    {
        public Int64 AppointmentPrescriptionDetailsID { get; set; }
        public string Dosage { get; set; }
        public UnitEnum UnitEnum { get; set; }
        public FrequencyEnum FrequencyEnum { get; set; }
        [ForeignKey("Medicines")]
        public Int64 MedidcineID { get; set; }
        public virtual Medicine Medicines { get; set; }
    }
}

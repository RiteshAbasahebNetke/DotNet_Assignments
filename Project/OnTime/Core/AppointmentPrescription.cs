using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class AppointmentPrescription
    {
        public Int64 AppointmentPrescriptionID { get; set; }
        public DateTime Prescription { get; set; }
        [ForeignKey("Doctor")]
        public Int64 DoctorID { get; set; }
        public virtual Doctor Doctor { get; set; }
        [ForeignKey("BookedAppointments")]
        public Int64 BookedAppointmentsID { get; set; }
        public virtual BookedAppointments BookedAppointments { get; set; }  
    }
}

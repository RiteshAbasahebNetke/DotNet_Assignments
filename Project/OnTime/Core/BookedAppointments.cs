using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("BookedAppointmentsTbl")]
    public class BookedAppointments
    {
        [Key]
        public Int64 BookedAppointmentsID { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public Int64 IsPaid { get; set; }
        [ForeignKey("DoctorClinicSession")]
        public Int64 DoctorClinicSessionID { get; set; }
        public virtual DoctorClinicSession DoctorClinicSession { get; set; }
        [ForeignKey("Patient")]
        public Int64 PatientID { get; set; }
        public virtual Patient Patient { get; set; }
    }
}

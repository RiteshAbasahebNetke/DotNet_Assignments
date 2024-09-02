using Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.ViewModels
{
    public class BookAppVM
    {
        public DateTime AppointmentDate { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public Int64 IsPaid { get; set; }
        public Int64 DoctorClinicSessionID { get; set; }
        public Int64 PatientID { get; set; }
    }
}

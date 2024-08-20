using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.ViewModels
{
    public class DrClSessionVM
    {
        public Int64 DoctorClinicSessionID { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public int TimeInterval { get; set; }
        public Int64 DoctorID { get; set; }
        public Int64 ClinicID { get; set; }
        public Int64 OpdSessionID { get; set; }
        public string SessionName { get; set; }
    }
}

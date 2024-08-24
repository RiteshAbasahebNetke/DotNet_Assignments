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
        public List<string> StartTime { get; set; }
        public List<string> EndTime { get; set; }
        public List<int> TimeInterval { get; set; }
        public List<Int64> DoctorID { get; set; }
        public List<Int64> ClinicID { get; set; }
        public List<Int64> OpdSessionID { get; set; }
        public List<string> SessionName { get; set; }
    }
}

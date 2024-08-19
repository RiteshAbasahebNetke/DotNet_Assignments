using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.ViewModels
{
    public class GetDoctorsVM
    {
        public Int64 DoctorID { get; set; }
        public string FullName { get; set; }
        public bool IsAvailable { get; set; }
        public IFormFile DoctorPhoto { get; set; }
        public string DoctorExperience { get; set; }
        public string DoctorQualification { get; set; }
        public Int64 ClinicID { get; set; }
        public string ClinicName { get; set; }
        public Int64 SpecilityID { get; set; }
        public string SpecilityName { get; set; }
    }
}

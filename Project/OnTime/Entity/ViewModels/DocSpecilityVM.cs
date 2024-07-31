using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.ViewModels
{
    public class DocSpecilityVM
    {
        public Int64 DoctorSpecilityID { get; set; }
        public Int64 DoctorID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        public string MobileNo { get; set; }
        public bool IsAvailable { get; set; }
        public string Address { get; set; }
        public string DoctorExperience { get; set; }
        public IFormFile DoctorPhoto { get; set; }
        public string PhotoPath { get; set; }
        public string DoctorQualification { get; set; }
        public string Password { get; set; }
        public Int64 SpecilityID { get; set; }
        public string SpecilityName { get; set; }   
        public Int64 AreaID { get; set; }
        public string AreaName { get; set; }
    }
}

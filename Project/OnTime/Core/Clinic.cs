using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("ClinicTbl")]
    public class Clinic
    {
        [Key]
        public Int64 ClinicID { get; set; }
        public string ClinicName { get; set; }
        public string Address { get; set; }
        public string MobileNo { get; set; }
        public string EmailID { get; set; }
        public string ContactPersonName { get; set; }
        public string LandLineNo { get; set; }
        public string WebsiteUrl { get; set; }
        public string Password { get; set; }
        [ForeignKey("City")]
        public Int64 CityID { get; set; }
        public virtual City City { get; set; }
        public virtual List<ClinicFacility> ClinicFacilities { get; set; }
        public virtual List<OPDSession> OPDSessions { get; set; }
        public virtual List<ClinicRating> ClinicRatings { get; set; }
        public virtual List<ClinicCertificate> ClinicCertificates { get; set; }
        public virtual List<DoctorClinicSession> DoctorClinicSessions { get; set; }
    }
}

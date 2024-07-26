using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("DoctorTbl")]
    public class Doctor
    {
        public class Patient
        {
            [Key]
            public Int64 DoctorID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string MobileNo { get; set; }
            public bool IsAvailable { get; set; }
            public string Address { get; set; }
            public string DoctorExperience { get; set; }
            public string PhotoPath { get; set; }
            public string DoctorQualification { get; set; }
            public string Password { get; set; }

            [ForeignKey("Area")]
            public Int64 AreaID { get; set; }
            public virtual Area Area { get; set; }
        }
    }
}

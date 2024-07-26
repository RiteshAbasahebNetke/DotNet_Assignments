﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("DoctorSpecialityTbl")]
    public class DoctorSpeciality
    {
        [Key]
        public Int64 DoctorSpecilityID { get; set; }
        [ForeignKey("Doctor")]
        public Int64 DoctorID { get; set; }
        public virtual Doctor Doctor { get; set; }
        [ForeignKey("Specility")]
        public Int64 SpecilityID { get; set; }
        public virtual Specility Specility { get; set; }
    }
}

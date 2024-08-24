using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.ViewModels
{
    public class DoctorRatingVM
    {
        public Int64 DoctorID { get; set; }
        public Doctor Doctor { get; set; }
        public IEnumerable<DoctorRating> Ratings { get; set; }
        public int Rating { get; set; }
        public Int64 UserID { get; set; }
        public string Review { get; set; }
        public string FirstName { get; set; }
    }
}

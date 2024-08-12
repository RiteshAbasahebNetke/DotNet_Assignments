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
        public Doctor Doctor { get; set; }
        public IEnumerable<DoctorRating> Ratings { get; set; }
        public DoctorRating NewRating { get; set; }
        public string Review { get; set; }
        public string FullName { get; set; }
    }
}

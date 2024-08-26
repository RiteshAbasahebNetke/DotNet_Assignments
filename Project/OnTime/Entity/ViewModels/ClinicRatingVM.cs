using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.ViewModels
{
    public class ClinicRatingVM
    {
        public Int64 ClinicID { get; set; }
        public Clinic Clinic { get; set; }
        public IEnumerable<ClinicRating> Ratings { get; set; }
        public int Rating { get; set; }
        public Int64 UserID { get; set; }
        public string Review { get; set; }
        public string FirstName { get; set; }
    }
}

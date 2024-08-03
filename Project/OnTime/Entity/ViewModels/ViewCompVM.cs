using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.ViewModels
{
    public class ViewCompVM
    {
        public Int64 CountryID { get; set; }
        public string CountryName { get; set; }
        public Int64 StateID { get; set; }
        public string StateName { get; set; }
        public Int64 CityID { get; set; }
        public string CityName { get; set; }
        public Int64 SpecilityID { get; set; }
        public string SpecilityName { get; set; }
    }
}

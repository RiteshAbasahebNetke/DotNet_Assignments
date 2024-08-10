//using Core;
//using Entity.Repositories.Interfaces;
//using Entity.ViewModels;
//using Microsoft.AspNetCore.Mvc;
//using System.Runtime.CompilerServices;

//namespace Web.ViewComponents
//{
//    public class ViewDocCSCVC:ViewComponent
//    {
//        IDoctorRepo drepo;
//        public ViewDocCSCVC(IDoctorRepo drepo)
//        {
//            this.drepo = drepo;
//        }
//        public IViewComponentResult Invoke(Doctor rec,Int64 CountryID=0,Int64 StateID=0,Int64 CityID=0,Int64 SpecilityID=0)
//        {

//            if(CountryID>0 || StateID>0 || CityID>0 || SpecilityID>0)
//            {
                
//            }
//            return View();
//        }
//    }
//}

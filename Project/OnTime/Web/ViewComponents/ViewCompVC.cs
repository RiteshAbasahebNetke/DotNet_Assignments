using Core;
using Entity.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Web.ViewComponents
{
    public class ViewCompVC:ViewComponent
    {
        ICountryRepo crepo;
        IStateRepo srepo;
        ICityRepo ctrepo;
        ISpecilityRepo sprepo;
        IDoctorRepo drepo;

        public ViewCompVC(ICountryRepo crepo, IStateRepo srepo, ICityRepo ctrepo, ISpecilityRepo sprepo,IDoctorRepo drepo)
        {
            this.crepo = crepo;
            this.srepo = srepo;
            this.ctrepo = ctrepo;
            this.sprepo = sprepo;
            this.drepo = drepo;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.CountryID = new SelectList(this.crepo.GetAll(), "CountryID", "CountryName");
            ViewBag.StateID = new SelectList(this.srepo.GetAll(), "StateID", "StateName");
            ViewBag.CityID = new SelectList(this.ctrepo.GetAll(), "CityID", "CityName");
            ViewBag.SpecilityID = new SelectList(this.sprepo.GetAll(), "SpecilityID", "SpecilityName");
            
            return View();
        }
    }
}

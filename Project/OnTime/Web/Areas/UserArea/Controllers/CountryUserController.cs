using Entity.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Web.CustAuthFilters;

namespace Web.Areas.UserArea.Controllers
{
    [Area("UserArea")]
    [UserAuth]
    public class CountryUserController : Controller
    {
        ICountryRepo crepo;
        public CountryUserController(ICountryRepo crepo)
        {
            this.crepo = crepo;
        }
        public IActionResult Index()
        {
            return View(this.crepo.GetAll());
        }
    }
}

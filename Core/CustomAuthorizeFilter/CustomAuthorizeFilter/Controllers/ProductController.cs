using CustomAuthorizeFilter.Repositories.Interface;
using Microsoft.AspNetCore.Mvc;

namespace CustomAuthorizeFilter.Controllers
{
    public class ProductController : Controller
    {
        IProductRepo prepo;
        public ProductController(IProductRepo prepo)
        {
            this.prepo = prepo;
        }

        public IActionResult Index()
        {
            return View(this.prepo.GetAll());
        }
    }
}

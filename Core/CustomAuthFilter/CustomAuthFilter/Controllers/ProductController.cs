using CustomAuthFilter.CustAuthFilter;
using CustomAuthFilter.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CustomAuthFilter.Controllers
{
    [UserAuth]
    public class ProductController : Controller
    {
        IProductRepo prepo;
        public ProductController(IProductRepo prepo)
        {
            this.prepo = prepo;
        }
        public IActionResult Index()
        {
            var res = this.prepo.GetAll();
            return View(res.ToList());
        }
    }
}

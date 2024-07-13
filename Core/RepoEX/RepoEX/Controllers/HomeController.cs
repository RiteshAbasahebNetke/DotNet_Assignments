using Microsoft.AspNetCore.Mvc;
using RepoEX.Repositories;

namespace RepoEX.Controllers
{
    public class HomeController : Controller
    {
        IProductRepo prepo;
        public HomeController(IProductRepo tprepo)
        {   `
            this.prepo = tprepo;
        }
        public IActionResult Index()
        {
            return View(this.prepo.GetProducts());
        }
    }
}

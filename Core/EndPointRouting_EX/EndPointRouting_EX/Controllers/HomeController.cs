using EndPointRouting_EX.Models;
using Microsoft.AspNetCore.Mvc;

namespace EndPointRouting_EX
{
    public class HomeController: Controller
    {
        
        public string Index()
        {
            return "Index Action of Home Controller Called..!";
        }
        [Route("ho/cu/{a}")]
        public int Cube(int a)
        {
            return a * a * a;
        }
        public ActionResult About()
        {
            return View();
        }
        [Route("ho/gp")]
        public IActionResult GetProduct()
        {
            var rec = Product.GetAllProducts();
            return View(rec);
        }
    }
}

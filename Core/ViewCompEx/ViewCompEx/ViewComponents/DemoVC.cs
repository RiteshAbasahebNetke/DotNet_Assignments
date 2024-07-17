
using Microsoft.AspNetCore.Mvc;

namespace ViewCompEx.ViewComponents
{
    public class DemoVC : ViewComponent
    {
       public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

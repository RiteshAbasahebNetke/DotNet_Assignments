using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace ExceptionHandlingEx.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult Index()
        {
            var info = HttpContext.Features.Get<IExceptionHandlerPathFeature>();
            
            ViewBag.Message = info.Error.Message;
            ViewBag.Path = info.Path;
            ViewBag.Stack = info.Error.StackTrace;
            return View();
        }
    }
}

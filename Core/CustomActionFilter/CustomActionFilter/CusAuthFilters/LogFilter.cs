using CustomActionFilter.Models;
using Microsoft.AspNetCore.Mvc.Filters;

namespace CustomActionFilter.CusAuthFilters
{
    public class LogFilter:ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var cntx = context.HttpContext.RequestServices.GetRequiredService<LogContext>();
            ActionLog rec = new ActionLog();
            rec.LogDateTime = DateTime.Now;
            rec.ActionName = context.RouteData.Values["action"].ToString();
            rec.ControllerName = context.RouteData.Values["controller"].ToString();
            cntx.ActionLogs.Add(rec);
            cntx.SaveChanges();
        }
    }
}

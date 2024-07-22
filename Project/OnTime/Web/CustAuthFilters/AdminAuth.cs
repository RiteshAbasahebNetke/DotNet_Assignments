using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;

namespace Web.CustAuthFilters
{
    public class AdminAuth : ActionFilterAttribute, IAuthorizationFilter
    {
            public void OnAuthorization(AuthorizationFilterContext context)
            {
                if (context.HttpContext.Session.GetString("AdminID") == null)
                {
                    context.Result = new RedirectToActionResult("Login", "ManageAdmin", new { area = "" });
                }
            }
      
    }
}

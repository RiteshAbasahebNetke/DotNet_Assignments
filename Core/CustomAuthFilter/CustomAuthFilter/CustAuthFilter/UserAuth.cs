using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace CustomAuthFilter.CustAuthFilter
{
    public class UserAuth:ActionFilterAttribute,IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            if (context.HttpContext.Session.GetString("UserID") == null)
            {
                context.Result = new RedirectToRouteResult(new RouteValueDictionary(new { controller = "ManageUsers", action = "Login" }));
            }
        }
    }
}

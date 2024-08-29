using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;

namespace Web.CustAuthFilters
{
    public class DoctorAuth:ActionFilterAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            if (context.HttpContext.Session.GetString("DoctorID") == null)
            {
                context.Result = new RedirectToActionResult("Signin", "ManageDoctor", new { area = "" });
            }
        }
    }
}

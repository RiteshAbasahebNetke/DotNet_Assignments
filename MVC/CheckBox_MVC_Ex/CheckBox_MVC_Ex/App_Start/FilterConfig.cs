using System.Web;
using System.Web.Mvc;

namespace CheckBox_MVC_Ex
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

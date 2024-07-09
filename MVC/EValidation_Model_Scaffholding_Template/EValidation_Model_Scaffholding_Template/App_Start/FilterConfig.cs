using System.Web;
using System.Web.Mvc;

namespace EValidation_Model_Scaffholding_Template
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

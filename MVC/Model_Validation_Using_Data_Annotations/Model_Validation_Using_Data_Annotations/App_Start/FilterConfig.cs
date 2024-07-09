using System.Web;
using System.Web.Mvc;

namespace Model_Validation_Using_Data_Annotations
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

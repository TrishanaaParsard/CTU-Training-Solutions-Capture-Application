using System.Web;
using System.Web.Mvc;

namespace CTU_Training_Solutions_Capture_Application
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

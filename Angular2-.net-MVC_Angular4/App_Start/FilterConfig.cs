using System.Web;
using System.Web.Mvc;

namespace Angular2_.net_MVC_Angular4
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

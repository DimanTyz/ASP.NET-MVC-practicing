using System.Web;
using System.Web.Mvc;

namespace Lesson2_UrlIdFind
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

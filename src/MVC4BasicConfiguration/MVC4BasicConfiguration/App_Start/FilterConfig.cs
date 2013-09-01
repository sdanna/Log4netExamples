using System.Web;
using System.Web.Mvc;
using MVC4BasicConfiguration.Attributes;

namespace MVC4BasicConfiguration
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new HandleExceptionsAttribute());
        }
    }
}
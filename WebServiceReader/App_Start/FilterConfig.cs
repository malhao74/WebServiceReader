using System.Web;
using System.Web.Mvc;

namespace WebServiceReader
{
    public static class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            if (filters == null)
            {
                return;
            }
            filters.Add(new HandleErrorAttribute());
        }
    }
}

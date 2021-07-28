using Sample_First.Filters;
using System.Web;
using System.Web.Mvc;

namespace Sample_First
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new KMI4ActionFilter());

            // filters.Add(new KMI3ActionFilter());
            //filters.Add(new KMIActionFilter());
            filters.Add(new HandleErrorAttribute());
        }
    }
}

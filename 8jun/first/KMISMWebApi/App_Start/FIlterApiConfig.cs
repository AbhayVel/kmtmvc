using Demo.filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Filters;

namespace KMISMWebApi.App_Start
{
    public class FIlterApiConfig
    {

        public static void RegisterGlobalFilters(HttpFilterCollection filters)
        {
            filters.Add(new QDNExceptionApiFIlter());
              filters.Add(new QdnAuthenticationApiFilter());
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http.Filters;

namespace Demo.filters
{
    public class QDNExceptionApiFIlter : ExceptionFilterAttribute
    {
        //    public Logger logger = LogManager.GetCurrentClassLogger();
        //
        // Summary:
        //     Raises the exception event.
        //
        // Parameters:
        //   actionExecutedContext:
        //     The context for the action.
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {

        }
        public override Task OnExceptionAsync(HttpActionExecutedContext actionExecutedContext, CancellationToken cancellationToken)
        {


            //   actionExecutedContext.Response = actionExecutedContext.Request.CreateErrorResponse(System.Net.HttpStatusCode.InternalServerError, actionExecutedContext.Exception);

            actionExecutedContext.Response = new HttpResponseMessage(System.Net.HttpStatusCode.InternalServerError);
            actionExecutedContext.Response.Content = new StringContent("There is interal server Error " + actionExecutedContext.Exception.Message);
            actionExecutedContext.Response.ReasonPhrase = actionExecutedContext.Exception.Message;
            return Task.CompletedTask;
        }

    }
}
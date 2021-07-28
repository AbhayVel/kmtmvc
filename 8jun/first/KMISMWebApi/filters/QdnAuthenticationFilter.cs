using KMISMEntities;
using KMISMModels;
using KmiUtitlity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http.Filters;
using System.Web.Http.Results;
using System.Web.Mvc.Filters;

namespace Demo.filters
{
    public class QdnAuthenticationApiFilter : System.Web.Http.Filters.IAuthenticationFilter
    {
        public bool AllowMultiple { get; set; }

        public LoginUserModel GetloginUserModel(string userStringEnc)
        {

            LoginUserModel loginUserModel = null;

            if (!string.IsNullOrWhiteSpace(userStringEnc))
            {
                try
                {
                    var userString = EncryptDecrypt.Decrypt(userStringEnc, "1234567890123456");

                    var loinUser = JsonConvert.DeserializeObject<LoginUser>(userString);

                    if ((DateTime.Now - loinUser.ExpiryDateTime).TotalMinutes < 30)
                    {
                        loginUserModel = new LoginUserModel();
                        loginUserModel.Identity = loinUser as IIdentity;
                        //  context.Principal = loginUserModel as IPrincipal;
                        return loginUserModel;
                    }
                }
                catch
                {

                }
            }

            return null;
        }

        public Task AuthenticateAsync(HttpAuthenticationContext context, CancellationToken cancellationToken)
        {
            if (context.Request.RequestUri.LocalPath.StartsWith("/api/LoginApi"))
            {
                return Task.CompletedTask;
            }
           

            var token = context.Request.Headers.FirstOrDefault(x => x.Key == "Token");

            var userStringEnc =token.Value==null ? "" : token.Value.FirstOrDefault().ToString();
            var loginUserModel = GetloginUserModel(userStringEnc);
            context.Principal = loginUserModel as IPrincipal;
            

            return Task.CompletedTask;
        }

        public Task ChallengeAsync(HttpAuthenticationChallengeContext context, CancellationToken cancellationToken)
        {   
            return Task.CompletedTask;
        }
    }
}
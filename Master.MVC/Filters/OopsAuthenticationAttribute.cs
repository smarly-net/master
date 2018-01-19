using System;
using System.Diagnostics;
using System.Web.Mvc;
using System.Linq;
using System.Security.Principal;
using System.Web.Mvc.Filters;
using System.Web.Routing;

namespace Master.MVC.Filters
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public class OopsAuthenticationAttribute : FilterAttribute, IAuthenticationFilter
    {
        public void OnAuthentication(AuthenticationContext filterContext)
        {
            Debug.WriteLine("OopsAuthenticationAttribute::OnAuthentication");
            IIdentity ident = filterContext.Principal.Identity;
            if (!ident.IsAuthenticated || !ident.Name.EndsWith("@godeltech.com"))
            {
                filterContext.Result = new HttpUnauthorizedResult();
            }
        }

        public void OnAuthenticationChallenge(AuthenticationChallengeContext filterContext)
        {
            if (filterContext.Result == null || filterContext.Result is HttpUnauthorizedResult)
            {
                filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary {
                    {"controller", "Home"},
                    {"action",  "Login"},
                    {"returnUrl", filterContext.HttpContext.Request.RawUrl}
                });
            }
        }
    }
}
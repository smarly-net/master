using System;
using System.Web.Mvc;
using System.Linq;

namespace Master.MVC.Filters
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public class OopsAuthAttribute : FilterAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            var paramCollection = filterContext.HttpContext.Request.Params;

            bool? isAuth = paramCollection.GetValues("Oops")?.Any(x => x.Equals("me", StringComparison.InvariantCultureIgnoreCase));

            if (!isAuth.HasValue || !isAuth.Value)
            {
                filterContext.Result = new HttpUnauthorizedResult();
            }
        }
    }
}
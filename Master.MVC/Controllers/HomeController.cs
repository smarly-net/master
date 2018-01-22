using System;
using System.Diagnostics;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Filters;
using System.Web.Routing;

namespace Master.MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string id)
        {
            if (id == "none")
            {
                throw new NotImplementedException();
            }

            return this.View();
        }

        #region Overrides of Controller

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Debug.WriteLine("IActionFilter::OnActionExecuting");
            base.OnActionExecuting(filterContext);
        }

        protected override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Debug.WriteLine("IActionFilter::OnActionExecuted");
            base.OnActionExecuted(filterContext);
        }

        protected override void OnAuthentication(AuthenticationContext filterContext)
        {
            Debug.WriteLine("IAuthenticationFilter::OnAuthentication");
            base.OnAuthentication(filterContext);
        }

        protected override void OnAuthenticationChallenge(AuthenticationChallengeContext filterContext)
        {
            Debug.WriteLine("IAuthenticationFilter::OnAuthenticationChallenge");
            base.OnAuthenticationChallenge(filterContext);
        }

        protected override void OnAuthorization(AuthorizationContext filterContext)
        {
            Debug.WriteLine("IAuthorizationFilter::OnAuthorization");
            base.OnAuthorization(filterContext);
        }

        protected override void OnException(ExceptionContext filterContext)
        {
            Debug.WriteLine("IExceptionFilter::OnException");
            base.OnException(filterContext);
        }

        protected override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            Debug.WriteLine("IResultFilter::OnResultExecuted");
            base.OnResultExecuted(filterContext);
        }

        protected override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            Debug.WriteLine("IResultFilter::OnResultExecuting");
            base.OnResultExecuting(filterContext);
        }

        #endregion
    }
}
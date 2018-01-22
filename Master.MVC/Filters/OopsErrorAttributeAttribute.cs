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
    public class OopsErrorAttributeAttribute : FilterAttribute, IExceptionFilter
    {
        #region Implementation of IExceptionFilter

        public void OnException(ExceptionContext filterContext)
        {
            var ex = filterContext.Exception as ArgumentNullException;

            if (ex != null)
            {
                filterContext.ExceptionHandled = true;
                filterContext.Result = new ContentResult(){Content = ex.Message};
            }
        }

        #endregion
    }
}
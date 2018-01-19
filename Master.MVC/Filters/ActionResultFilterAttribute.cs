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
    public class ActionResultFilterAttribute : FilterAttribute, IActionFilter, IResultFilter
    {
        private readonly Stopwatch _sw;
        public ActionResultFilterAttribute()
        {
            this._sw = Stopwatch.StartNew();
        }

        #region Implementation of IActionFilter

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            this._sw.Restart();
            Debug.WriteLine("IActionFilter::OnActionExecuting");
            Debug.WriteLine(this._sw.ElapsedMilliseconds);
        }

        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Debug.WriteLine("IActionFilter::OnActionExecuted");
            Debug.WriteLine(this._sw.ElapsedMilliseconds);
        }

        #endregion

        #region Implementation of IResultFilter

        public void OnResultExecuting(ResultExecutingContext filterContext)
        {
            Debug.WriteLine("IResultFilter::OnResultExecuting");
            Debug.WriteLine(this._sw.ElapsedMilliseconds);
        }

        public void OnResultExecuted(ResultExecutedContext filterContext)
        {
            Debug.WriteLine("IResultFilter::OnResultExecuted");
            Debug.WriteLine(this._sw.ElapsedMilliseconds);
        }

        #endregion
    }
}
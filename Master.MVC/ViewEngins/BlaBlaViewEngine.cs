using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Web.Mvc;

namespace Master.MVC.ViewEngins
{
    public class BlaBlaViewEngine : IViewEngine
    {
        public ViewEngineResult FindPartialView(ControllerContext controllerContext, string partialViewName, bool useCache)
        {
            throw new System.NotImplementedException();
        }

        public ViewEngineResult FindView(ControllerContext controllerContext, string viewName, string masterName, bool useCache)
        {
            if (viewName.Equals("Oops", StringComparison.InvariantCultureIgnoreCase))
            {
                return new ViewEngineResult(new OopsView(), (IViewEngine)this);
            }

            return new ViewEngineResult(new string[0]);
        }

        public void ReleaseView(ControllerContext controllerContext, IView view)
        {
        }
    }

    public class OopsView : IView
    {
        public void Render(ViewContext viewContext, TextWriter writer)
        {
            writer.Write("Oops page");
        }
    }
}
using System.Web.Mvc;
using System.Web.Routing;

using Master.MVC.ViewEngins;

namespace Master.MVC
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            ViewEngines.Engines.Clear();
            ViewEngines.Engines.Add(new BlaBlaViewEngine());
            ViewEngines.Engines.Add(new RazorViewEngine());

            RouteTable.Routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
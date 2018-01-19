using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.SessionState;

namespace Master.MVC
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            RouteTable.Routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}",
                defaults: new { controller = "Home", action = "Index" }
            );
        }
    }
}
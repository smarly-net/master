using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Master.MVC
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //routing doesn't know anything about variables controller and action

            Route myRoute = new Route(
                "{controller}/{action}/{id}", 
                new RouteValueDictionary
                {
                    { "controller", "Home"},
                    { "action", "Index" },
                    { "id", UrlParameter.Optional  }
                },
                new MvcRouteHandler());

            RouteTable.Routes.Add("Default_Route", myRoute);
        }
    }
}
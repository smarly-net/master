using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Master.MVC
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            RouteTable.Routes.RouteExistingFiles = true;
            RouteTable.Routes.MapRoute(
                name: "ActionPage",
                url: "{action}-page",
                defaults: new { controller = "Home" }
            );

            RouteTable.Routes.MapRoute(
                name: "Hello",
                url: "hello/mvc",
                defaults: new { controller = "Home", action = "About" }
            );

            RouteTable.Routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{name}",
                defaults: new { controller = "Home", action = "Index", name = "Godel" }/*,
                constraints: new { controller = "^H.*", action = "^Index$|^About$" }*/
            );

            RouteTable.Routes.MapRoute(
                name: "AllUrls",
                url: "any/{*url}",
                defaults: new { controller = "Home", action = "Common" }/*,
                constraints: new { chromeConstraint = new UserAgentConstraint("Chrome") }*/
            );
        }
    }

    public class UserAgentConstraint : IRouteConstraint
    {
        private string requiredUserAgent;
        public UserAgentConstraint(string agentParam)
        {
            requiredUserAgent = agentParam;
        }
        public bool Match(HttpContextBase httpContext, Route route, string parameterName,
            RouteValueDictionary values, RouteDirection routeDirection)
        {
            return httpContext.Request.UserAgent != null &&
                   httpContext.Request.UserAgent.Contains(requiredUserAgent);
        }
    }
}
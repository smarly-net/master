using System.Web;
using System.Web.Routing;

namespace Master.MVC
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            RouteTable.Routes.Add("MyRoute", new Route("{*blam}", new SampleRouteHandler()));
        }
    }

    public class SampleRouteHandler : IRouteHandler
    {
        public IHttpHandler GetHttpHandler(RequestContext requestContext)
        {
            return new SampleHttpHandler(requestContext.RouteData);
        }
    }

    public class SampleHttpHandler : IHttpHandler
    {
        private readonly RouteData _routeData;

        public SampleHttpHandler(RouteData routeData)
        {
            _routeData = routeData;
        }

        public void ProcessRequest(HttpContext context)
        {
            var val = _routeData.Values["blam"];

            var response = context.Response;

            response.Write($"Your request was '{val}'");
        }

        public bool IsReusable { get; }
    }
}
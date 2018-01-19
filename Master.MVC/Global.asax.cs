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

//        protected void Application_Error(object sender, EventArgs e)
//        {
//            Exception exception = Server.GetLastError();
//            Response.Clear();
//
//            HttpException httpException = exception as HttpException;
//            if (httpException != null)
//            {
//                string action;
//                switch (httpException.GetHttpCode())
//                {
//                    case 404:
//                        action = "HttpError404";
//                        break;
//                    default:
//                        action = "General";
//                        break;
//                }
//                // clear error on server
//                Server.ClearError();
//
//                Response.Redirect($"~/Error/{action}/?message={exception.Message}");
//            }
//        }
    }
}
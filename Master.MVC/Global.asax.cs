using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace Master.MVC
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            RouteTable.Routes.MapPageRoute("HelloPageRoute",
                                           "Hello",
                                           "~/Pages/Hello.aspx");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace Master.MVC
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            HttpContext context = base.Context;
            var request = context.Request;
            var response = context.Response;

            var url = request.Url.PathAndQuery;

            response.Write($"Your request was '{url}'");
            base.CompleteRequest();
        }
    }
}
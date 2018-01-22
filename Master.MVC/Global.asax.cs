using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;


namespace Master.MVC
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            ModelBinders.Binders.Clear();
            ModelBinders.Binders.Add(typeof(HttpPostedFileBase), new HttpPostedFileBaseModelBinder());
            ModelBinders.Binders.Add(typeof(byte[]), new ByteArrayModelBinder());
            ModelBinders.Binders.Add(typeof(System.Data.Linq.Binary), new LinqBinaryModelBinder());
            ModelBinders.Binders.Add(typeof(CancellationToken), new CancellationTokenModelBinder());

            RouteTable.Routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}",
                defaults: new { controller = "Home", action = "Index" }
            );
        }

    }
}
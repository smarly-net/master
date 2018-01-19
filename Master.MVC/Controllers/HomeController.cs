using System.Diagnostics;
using System.Web.Mvc;

using Master.MVC.Filters;

namespace Master.MVC.Controllers
{
    public class HomeController : Controller
    {
        [OopsAuth]
//        [Authorize]
        public string Index()
        {
            Debug.WriteLine("Index");
            return "Hello MVC";
        }

        public string About()
        {
            return "About MVC";
        }
    }
}
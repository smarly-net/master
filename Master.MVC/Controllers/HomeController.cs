using System.Diagnostics;
using System.Web.Mvc;

using Master.MVC.Filters;

namespace Master.MVC.Controllers
{
    public class HomeController : Controller
    {
        [ActionResultFilterAttribute]
        public ActionResult Index()
        {
            return View();
        }

        public string About()
        {
            return "About MVC";
        }
    }
}
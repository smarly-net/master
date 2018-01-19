using System.Web.Mvc;

namespace Master.MVC.Controllers
{
    [RoutePrefix("Hello")]
    public class HomeController : Controller
    {
        [Route("~/")]
        [Route("home")]
        [Route("")]
        public string Index()
        {
            return "Hello MVC";
        }
        [Route("about")]
        public string About()
        {
            return "About MVC";
        }
    }
}
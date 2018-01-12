using System.Web.Mvc;

namespace Master.MVC.Controllers
{
    public class HomeController : Controller
    {
        public string Index(string name)
        {
            return $"Hello {name}";
        }

        public string About()
        {
            return "About page";
        }

        public string Common(string url)
        {
            return url;
        }
    }
}
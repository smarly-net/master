using System.Diagnostics;
using System.Web.Mvc;

using Master.MVC.Filters;

namespace Master.MVC.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Hello MVC";
        }

        [OopsAuthenticationAttribute]
        public string About()
        {
            return "About MVC";
        }

        public string Login()
        {
            return "Login Page";
        }
    }
}
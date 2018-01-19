using System.Web.Mvc;

namespace Master.MVC.Controllers {
    public class ErrorController : Controller
    {
        public string HttpError404()
        {
            return "HttpError404";
        }
        public string General()
        {
            return "General";
        }
    }
}
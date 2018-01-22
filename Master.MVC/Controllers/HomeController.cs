using System;
using System.Diagnostics;
using System.Web;
using System.Web.Mvc;

namespace Master.MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string id)
        {
            return this.View();
        }
    }
}
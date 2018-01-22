using System;
using System.Diagnostics;
using System.Web;
using System.Web.Mvc;

using Master.MVC.Filters;

namespace Master.MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                throw new ArgumentNullException(nameof(id));
            }

            return this.View((object)id);
        }
    }
}
using System;
using System.Data.Linq;
using System.Diagnostics;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Filters;
using System.Web.Routing;

namespace Master.MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string id)
        {
            return this.View();
        }

        [HttpPost]
        public string DecodeBase64(Binary binary)
        {
            return Encoding.UTF8.GetString(binary.ToArray());
        }
    }
}
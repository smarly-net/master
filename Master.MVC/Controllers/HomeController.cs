using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Master.MVC.Controllers
{
    public class ByRegion
    {
        [Required]

        public string Region { get; set; }
    }

    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index(string id)
        {
            return this.View();
        }

        [HttpPost]
        public ActionResult Index(ByRegion byRegion)
        {
            if (ModelState.IsValid)
            {
                return View("Result", byRegion);
            }
            else
            {
                return this.View();
            }
        }
    }
}
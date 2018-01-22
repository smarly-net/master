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
    //[ModelBinder(typeof(ByRegionBinder))]
    public class ByRegion
    {
        public ByRegion(string region)
        {
            Region = region;
        }

        public string Region { get; private set; }
    }

    public class ByRegionBinder : IModelBinder {
        #region Implementation of IModelBinder

        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            var code = controllerContext.HttpContext.Request.Form[bindingContext.ModelName];

            switch (code)
            {
                case "1":
                    return new ByRegion("Брестская область");
                case "2":
                    return new ByRegion("Витебская область");
                case "3":
                    return new ByRegion("Гомельская область");
                case "4":
                    return new ByRegion("Гродненская область");
                case "5":
                    return new ByRegion("Минская область");
                case "6":
                    return new ByRegion("Могилёвская область");
                case "7":
                    return new ByRegion("г. Минск");
                default:
                    throw new NotImplementedException();
            }
        }

        #endregion
    }

    public class HomeController : Controller
    {
        public ActionResult Index(string id)
        {
            return this.View();
        }

        [HttpPost]
        public string DecodeBase64(/*[ModelBinder(typeof(ByRegionBinder))]*/ByRegion region)
        {
            return region.Region;
        }
    }
}
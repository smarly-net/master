using System;
using System.Diagnostics;
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
        public string UploadFile(HttpPostedFileBase upload)
        {
            HttpPostedFileWrapper dublicateUpload = (HttpPostedFileWrapper) ControllerContext.HttpContext.Request.Files["upload"];

            byte[] bytes = new byte[upload.ContentLength];
            var length = upload.InputStream.Read(bytes, 0, upload.ContentLength);

            return upload.FileName;
        }
    }
}
﻿using System.Web.Mvc;

namespace Master.MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View("Oops");
        }
    }
}
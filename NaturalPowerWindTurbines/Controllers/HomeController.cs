using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NaturalPowerWindTurbines.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "This page describes how the application was developed.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Thank you for taking the time to review my application.";

            return View();
        }
    }
}
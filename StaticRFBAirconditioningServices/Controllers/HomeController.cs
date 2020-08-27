using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StaticRFB.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About us.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact us.";

            return View();
        }

        public ActionResult team()
        {
            ViewBag.Message = "Dev Team";

            return View();
        }



        public ActionResult services()
        {
            ViewBag.Message = "Services";

            return View();
        }

        public ActionResult Cleaning()
        {
            ViewBag.Message = "General Cleaning";

            return View();
        }


        public ActionResult Checkup()
        {
            ViewBag.Message = "General Cleaning";

            return View();
        }


        public ActionResult Repair()
        {
            ViewBag.Message = "General Cleaning";

            return View();
        }
    }
}
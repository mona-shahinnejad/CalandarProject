using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CalandarProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "This is a Test Calendar Appointment Shower by Mona Shahinnejad.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "You Can find my contacts below";

            return View();
        }
    }
}
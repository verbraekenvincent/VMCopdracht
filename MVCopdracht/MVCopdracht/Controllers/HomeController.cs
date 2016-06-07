using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCopdracht.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "This is an ASP.NET MVC application for Programmeren 5.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Please no contact.";

            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//Home controller is the code behind for ALL Views in the Home folder
namespace enterpriseweek8.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            //ViewBag is an empty object assigned to EVERY controller!
            //Message is a type, but ViewBag has no type
            //This allows dynamic allocation of properties to the controller
            //ViewBag is global, part of all methods and pages being called (views)
            //Can replace ViewBag with properly typed getters and setters
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
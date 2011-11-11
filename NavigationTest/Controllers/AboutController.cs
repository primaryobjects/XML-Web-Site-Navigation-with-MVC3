using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NavigationTest.Models;
using NavigationTest.Managers;

namespace NavigationTest.Controllers
{
    public class AboutController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Link1()
        {
            return View();
        }

        public ActionResult Link2()
        {
            return View();
        }

        public ActionResult Link3()
        {
            return View();
        }

        public ActionResult DisplayLeftNavigation()
        {
            return PartialView("~/Views/Navigation/LeftNavigation.cshtml", LeftNavigationManager.Load(ControllerContext.RouteData.Values["controller"].ToString()));
        }
    }
}

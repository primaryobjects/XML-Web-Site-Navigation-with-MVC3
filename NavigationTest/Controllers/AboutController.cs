using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NavigationTest.Models;
using NavigationTest.Managers;

namespace NavigationTest.Controllers
{
    public class AboutController : BaseNavigationController
    {
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
    }
}

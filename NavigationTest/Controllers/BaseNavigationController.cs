using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NavigationTest.Managers;

namespace NavigationTest.Controllers
{
    public abstract class BaseNavigationController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DisplaySubMenuNavigation()
        {
            return PartialView("~/Views/Navigation/SubMenuNavigation.cshtml", SubMenuNavigationManager.Load(ControllerContext.RouteData.Values["controller"].ToString()));
        }
    }
}

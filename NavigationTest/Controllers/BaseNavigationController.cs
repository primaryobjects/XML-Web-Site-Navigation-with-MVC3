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
        
        /// <summary>
        /// Displays the sub-menu navigation links for the parent menu item, identified by its controller name.
        /// This method returns the HTML for a list of sub-menu links.
        /// </summary>
        /// <returns>PartialView SubMenuNavigation.cshtml</returns>
        public ActionResult DisplaySubMenuNavigation()
        {
            return PartialView("~/Views/Navigation/SubMenuNavigation.cshtml", SubMenuNavigationManager.Load(ControllerContext.RouteData.Values["controller"].ToString()));
        }
    }
}

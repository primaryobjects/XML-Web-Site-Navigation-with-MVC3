using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NavigationTest.Models;

namespace NavigationTest.Managers
{
    public static class SubMenuNavigationManager
    {
        /// <summary>
        /// Helper methods to return available sub-menu links for this controller. Assume loading from a database, xml file, or other source, rather than hard-coded, etc.
        /// </summary>
        /// <param name="controllerName">Name of controller</param>
        /// <returns>LeftNavigationModel</returns>
        public static SubMenuNavigationModel Load(string controllerName)
        {
            SubMenuNavigationModel leftNavigation = new SubMenuNavigationModel();

            switch (controllerName)
            {
                case "Home":
                {
                    leftNavigation.Links.Add("Link 1", "/Home/Link1");
                    leftNavigation.Links.Add("Link 2", "/Home/Link2");
                }
                break;

                case "About":
                {
                    leftNavigation.Links.Add("Link 1", "/About/Link1");
                    leftNavigation.Links.Add("Link 2", "/About/Link2");
                    leftNavigation.Links.Add("Link 3", "/About/Link3");
                }
                break;
            };

            return leftNavigation;
        }
    }
}
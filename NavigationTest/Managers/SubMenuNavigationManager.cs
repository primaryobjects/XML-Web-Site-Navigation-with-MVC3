using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NavigationTest.Models;
using System.Xml;
using System.Xml.Linq;
using System.IO;

namespace NavigationTest.Managers
{
    public static class SubMenuNavigationManager
    {
        /// <summary>
        /// Helper methods to return available sub-menu links for this controller from XML.
        /// </summary>
        /// <param name="controllerName">Name of controller</param>
        /// <returns>LeftNavigationModel</returns>
        public static SubMenuNavigationModel Load(string controllerName)
        {
            SubMenuNavigationModel leftNavigation = new SubMenuNavigationModel();

            // Load the navigation XML document.
            XDocument xDoc = XDocument.Load(HttpContext.Current.Server.MapPath(@"~/Content/navigation.xml"));

            // Select all links for our navigation node (top-level menu item).
            var links = from node in xDoc.Descendants("node")
                        where (string)node.Attribute("title") == controllerName
                        select node.Elements("link");

            if (links.Count() > 0)
            {
                // Create a link for each item.
                foreach (var link in links.First())
                {
                    leftNavigation.Links.Add((string)link.Attribute("title"), (string)link.Attribute("href"));
                }
            }

            return leftNavigation;
        }

        #region Additional Example Load Methods

        /// <summary>
        /// Helper methods to return available sub-menu links for this controller from a hard-coded list. Assume loading from a database, xml file, or other source, rather than hard-coded, etc.
        /// </summary>
        /// <param name="controllerName">Name of controller</param>
        /// <returns>LeftNavigationModel</returns>
        public static SubMenuNavigationModel Load2(string controllerName)
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

        #endregion
    }
}
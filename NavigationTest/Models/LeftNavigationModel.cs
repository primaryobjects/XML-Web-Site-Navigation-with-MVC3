using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NavigationTest.Models
{
    public class LeftNavigationModel
    {
        public Dictionary<string, string> Links { get; set; }

        public LeftNavigationModel()
        {
            Links = new Dictionary<string, string>();
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.WebPages;

namespace MVCExamples
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

             
             DisplayModeProvider.Instance.Modes.Insert(0, new DefaultDisplayMode("testbrowser")
            {
                ContextCondition = (context => context.Request.UserAgent.IndexOf
                    ("testbrowser", StringComparison.OrdinalIgnoreCase) >= 0)
            });
        }
    }
}
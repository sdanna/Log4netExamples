using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using log4net;
using log4net.Config;

namespace MVC4BasicConfiguration
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
     

        protected void Application_Start()
        {
            LoggingConfig.Register(
                Server.MapPath("~/log4net.config"),
                Server.MapPath("~/Logs/"));

            var logger = LogManager.GetLogger(typeof (MvcApplication));
            logger.Info("===== Application Starting =====");

            logger.Debug("Debug Message");
            logger.Info("Info Message");
            logger.Warn("Warn Message");
            logger.Error("Error Message");
            logger.Fatal("Fatal Message");

            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AuthConfig.RegisterAuth();
        }
    }
}
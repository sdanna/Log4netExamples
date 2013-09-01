using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using log4net;

namespace MVC4BasicConfiguration.Attributes
{
    public class HandleExceptionsAttribute : HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            var logger = LogManager.GetLogger(filterContext.Controller.GetType());
            logger.Error("An unhandled exception has occured.",filterContext.Exception);
        }
    }
}
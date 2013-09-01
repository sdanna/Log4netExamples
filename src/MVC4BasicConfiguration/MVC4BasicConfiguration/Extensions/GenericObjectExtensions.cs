using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using log4net;


public static class GenericObjectExtensions
{
    public static ILog Logger<T>(this T @object)
    {
        var log = LogManager.GetLogger(typeof (T));
        return log;
    }
}

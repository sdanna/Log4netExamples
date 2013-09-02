using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace ConsoleAppBasicConfiguration.Logging
{
    public class LogManager
    {
        /// <summary>
        /// Gets a log4net Logger for the specified generic type.
        /// </summary>
        /// <typeparam name="T">Named logger type to get.</typeparam>
        /// <returns>ILog singleton instance for the specified generic type.</returns>
        public ILog GetLogger<T>()
        {
            var logger = log4net.LogManager.GetLogger(typeof (T));
            return logger;
        }
    }
}

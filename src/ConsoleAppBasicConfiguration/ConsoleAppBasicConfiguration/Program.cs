using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleAppBasicConfiguration.Logging;
using log4net;
using log4net.Config;

namespace ConsoleAppBasicConfiguration
{
    public class Program
    {
        private static Logging.LogManager _logManager = new Logging.LogManager();

        static void Main(string[] args)
        {
            XmlConfigurator.Configure(new FileInfo("log4net.config"));
            var logger = _logManager.GetLogger<Program>();
            logger.Info("===== Application Starting =====");

            AppDomain.CurrentDomain.UnhandledException += CurrentDomainOnUnhandledException;

            logger.Debug("Debug Message");
            logger.Info("Info Message");
            logger.Warn("Warning Message");
            logger.Error("Error Message");
            logger.Fatal("Error Message");

            logger.Info("===== Application Ending =====");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        private static void CurrentDomainOnUnhandledException(object sender, UnhandledExceptionEventArgs unhandledExceptionEventArgs)
        {
            var exception = unhandledExceptionEventArgs.ExceptionObject as Exception;
            if (exception != null)
            {
                var logger = _logManager.GetLogger<Program>();
                logger.Error("An unhandled exception has occured.", exception);
                logger.Info("===== Application Ending =====");

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Environment.Exit(1);
            }
        }
    }
}

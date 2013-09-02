using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleAppBasicConfiguration.Components;
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

            // Example object logging
            var loan = new Loan
                {
                    LoanAmount = 20.00, 
                    PaybackAmount = 25.00, 
                    NextPaymentDue = DateTime.Now,
                    LoanOfficer = new Person
                        {
                            Name = "Bob Johnson",
                            Title = "Vice President"
                        }
                };
            logger.Info(loan);

            // Console color logging
            logger.Debug("Debug Example");
            logger.Info("Info Example");
            logger.Warn("Warn Example");
            logger.Error("Error Example");
            logger.Fatal("Fatal Example");

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

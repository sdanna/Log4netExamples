using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using log4net.Config;

namespace ConsoleAppBasicConfiguration
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlConfigurator.Configure(new FileInfo("log4net.config"));
            LogManager.GetLogger(typeof(Program)).Info("===== Application Starting =====");




            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            LogManager.GetLogger(typeof(Program)).Info("===== Application Ending =====");
        }
    }
}

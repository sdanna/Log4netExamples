using System.IO;
using log4net.Config;

namespace MVC4BasicConfiguration
{
    public static class LoggingConfig
    {
        public static void Register(string configFile)
        {
            XmlConfigurator.Configure(new FileInfo(configFile));
        }
    }
}
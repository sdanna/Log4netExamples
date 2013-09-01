using System;
using System.IO;
using System.Linq;
using log4net.Config;

namespace MVC4BasicConfiguration
{
    public static class LoggingConfig
    {
        public static void Register(string configFile, string logFilePath)
        {
            // Setup log4net
            XmlConfigurator.Configure(new FileInfo(configFile));

            // Delete old log files.
            DeleteLogFilesOlderThanFiveDays(logFilePath);
        }


        private static void DeleteLogFilesOlderThanFiveDays(string logFilePath)
        {
            var files = new DirectoryInfo(logFilePath).GetFiles();

            var filesToDelete = from file in files
                                where file.LastWriteTime < DateTime.Now.AddDays(-5)
                                select file;

            foreach (var fileInfo in filesToDelete)
            {
                fileInfo.Delete();
            }
        }
    }
}
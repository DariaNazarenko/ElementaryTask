using log4net;
using log4net.Config;
using System.IO;
using System.Reflection;

namespace LoggerLibrary
{
    public static class Logger
    {
        public static void Initialize()
        {
            var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
            XmlConfigurator.Configure(logRepository, new FileInfo("log4net.config"));
        }
    }
}

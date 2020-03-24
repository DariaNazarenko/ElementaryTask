using EnvelopeTask.EnvelopeApp;
using log4net;
using LoggerLibrary;
using System;
using System.Reflection;

namespace EnvelopeTask
{
    class Program
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {
            Logger.Initialize();
            try
            {
                new Application().Run(args);
                log.Info("Application was built");
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                log.Error(e.Message);
            }
        }
    }
}

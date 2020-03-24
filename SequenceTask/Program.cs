using log4net;
using SequenceTask.SequenceApp;
using System;
using System.Reflection;
using LoggerLibrary;

namespace SequenceTask
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
                log.Info("Application was built.");
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                log.Error(e);
            }
            
        }
    }
}

using WriteNumberTask.WriteNumberApp;
using LoggerLibrary;
using System;
using log4net;
using System.Reflection;

namespace WriteNumberTask
{
    class Program
    {
		private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		static void Main(string[] args)
        {
			Logger.Initialize();

			try
			{
				Application.Run(args);
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

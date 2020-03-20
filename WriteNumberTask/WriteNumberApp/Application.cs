using WriteNumberTask.Models;
using WriteNumberTask.Logic;
using ValidationLibrary;
using System;
using log4net;
using System.Reflection;

namespace WriteNumberTask.WriteNumberApp
{
    static class Application
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        public static void Run(string[] args)
        {
            Numeric number = new Numeric { Number = Parser.GetIntegerValue(args[0]) };

            if (number != null)
            {
                var numberConvertor = new NumberConvertor();
                var numberInWords = numberConvertor.WriteNumber(number);

                Console.WriteLine(numberInWords);
                log.Info("Number was written");
            }
            else
            {
                log.Warn(new ArgumentNullException("Invalid input string"));
                throw new ArgumentNullException("Invalid input string");
            }

        }
    }
}

using static EnvelopeTask.Logic.Delegate;
using EnvelopeTask.Models;
using EnvelopeTask.Logic;
using ValidationLibrary;
using System;
using log4net;
using System.Reflection;

namespace EnvelopeTask.EnvelopeApp
{
    static class Application
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public static void Run(string[] args)
        {
            double[] sides = new Parser().GetDoubleArray(args);

            if (sides != null)
            {
                Envelope env1 = new Envelope(sides[0], sides[1]);
                Envelope env2 = new Envelope(sides[2], sides[3]);
                CheckDelegate check = new CheckDelegate(CheckSizeMethods.SimpleIfChecking);
                Console.WriteLine(check(env1, env2));
                log.Info("Envelopes were checked");
            }
            else
            {
                Console.WriteLine("Invalid input string");
                log.Error("Invalid input string");
            }
        }
    }
}

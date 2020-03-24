using static EnvelopeTask.Logic.Delegate;
using EnvelopeTask.Models;
using EnvelopeTask.Logic;
using ValidationLibrary;
using System;
using log4net;
using System.Reflection;

namespace EnvelopeTask.EnvelopeApp
{
    class Application
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public void Run(string[] args)
        {
            double[] sides = new Parser().GetDoubleArray(args);

            if (sides != null && !ContainsNegative(sides))
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

        private bool ContainsNegative(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {

                    return true;
                }
            }

            return false;
        }
    }
}

using SequenceTask.Models;
using SequenceTask.Logic;
using ValidationLibrary;
using SequenceTask.UI;
using System;
using log4net;
using System.Reflection;

namespace SequenceTask.SequenceApp
{
    static class Application
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public static void Run(string[] args)
        {
            int[] intArgs = Parser.GetIntegerArray(args);
            Sequence sequence = null;

            if (intArgs!=null && intArgs.Length == 2)
            {
                sequence = new Sequence(new FibonacciSequence(intArgs[0], intArgs[1]));
                log.Info("Fibonacci sequence was built");
            }
            else if (intArgs != null &&  intArgs.Length == 1)
            {
                sequence = new Sequence(new SqrtSequence(intArgs[0]));
                log.Info("Squared sequence was built");
            }
            else
            {
                log.Error("Invalid input string", new ArgumentException());
                throw new ArgumentException("Invalid input string");
            }

            var res = sequence.Algorithm();
            Print.PrintSequence(res);
        }
    }
}

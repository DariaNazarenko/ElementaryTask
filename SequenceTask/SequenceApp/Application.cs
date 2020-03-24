using SequenceTask.Validation;
using SequenceTask.Contracts;
using SequenceTask.Logic;
using ValidationLibrary;
using System.Reflection;
using SequenceTask.UI;
using System;
using log4net;

namespace SequenceTask.SequenceApp
{
    public class Application
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        private LocalValidator localValidator;
        private ISequenceGenerator sequence;
        private Parser parser;

        public Application()
        {
            localValidator = new LocalValidator();
            parser = new Parser();
        }

        public void Run(string[] args)
        {
            int[] intArgs = parser.GetIntegerArray(args);

            if (intArgs != null && !localValidator.ContainsNegative(intArgs) && intArgs.Length == 2)
            {
                sequence = new FibonacciSequence(intArgs[0], intArgs[1]);
                log.Info("Fibonacci sequence was initialized");
            }
            else if (intArgs != null && !localValidator.ContainsNegative(intArgs) && intArgs.Length == 1)
            {
                sequence = new SqrtSequence(intArgs[0]);
                log.Info("Squared sequence was initialized");
            }
            else
            {

                throw new ArgumentException("Invalid input string");
            }

            var res = sequence.GetSequence();
            Print.PrintSequence(res);
        }
    }
}

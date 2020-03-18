using SequenceTask.Models;
using SequenceTask.Logic;
using ValidationLibrary;
using SequenceTask.UI;
using System;

namespace SequenceTask.SequenceApp
{
    static class Application
    {
        public static void Run(string[] args)
        {
            int[] intArgs = Parser.GetIntegerArray(args);
            Sequence sequence = null;

            if (intArgs.Length == 2)
            {
                sequence = new Sequence(new FibonachiSequence(intArgs[0], intArgs[1]));
            }
            else if (intArgs.Length == 1)
            {
                sequence = new Sequence(new SqrtSequence(intArgs[0]));
            }
            else
            {
                Console.WriteLine("Invalid input string.");
            }

            var res = sequence.Algorithm();
            Print.PrintSequence(res);
        }
    }
}

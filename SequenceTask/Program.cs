using SequenceTask.Logic;
using SequenceTask.Models;
using SequenceTask.UI;
using System;
using ValidationLibrary;

namespace SequenceTask
{
    class Program
    {
        static int Main(string[] args)
        {
            int[] intArgs = new Validator(args).GetIntegerArray();
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
                return 1;
            }

            var res = sequence.Algorithm();
            new Print().PrintSequence(res);
            return 0;
        }
    }
}

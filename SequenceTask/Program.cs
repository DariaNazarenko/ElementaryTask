using SequenceTask.Logic;
using SequenceTask.Models;
using SequenceTask.Validation;
using System;

namespace SequenceTask
{
    class Program
    {
        static int Main(string[] args)
        {
            int[] intArgs = new Validate(args).ToIntArray();
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
            foreach (var item in res)
            {
                Console.Write($"{item}  ");
            }
            return 0;
        }
    }
}

using System;
using System.Collections.Generic;

namespace SequenceTask.UI
{
    class Print
    {
        public static void PrintSequence(IEnumerable<int> sequence)
        {
            foreach (var item in sequence)
            {
                Console.Write($"{item}  ");
            }
            Console.WriteLine();
        }
    }
}

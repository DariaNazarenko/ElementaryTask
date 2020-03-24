using System;
using System.Collections.Generic;

namespace SequenceTask.UI
{
    static class Print
    {
        public static void PrintSequence(List<int> sequence)
        {
            for (int i = 0; i < sequence.Count; i++)
            {
                if (i != sequence.Count - 1)
                {
                    Console.Write($"{sequence[i]}, ");
                }
                else
                {
                    Console.Write($"{sequence[i]} ");
                }
            }

            Console.WriteLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace SequenceTask.UI
{
    class Print
    {
        public void PrintSequence(IList<int> sequence)
        {
            foreach (var item in sequence)
            {
                Console.Write($"{item}  ");
            }
        }
    }
}

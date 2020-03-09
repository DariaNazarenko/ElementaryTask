using System;

namespace SequenceTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Sequence sequence = new Sequence(new FibonachiSequence(1,9));
            var res = sequence.Algorithm();
            foreach (var item in res)
            {
                Console.Write($"{item}  ");
            }
        }
    }
}

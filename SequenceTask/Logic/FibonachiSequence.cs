using SequenceTask.Contracts;
using System.Collections.Generic;

namespace SequenceTask.Logic
{
    class FibonachiSequence : ISequent
    {
        private int start;
        private int end;

        public FibonachiSequence(int start, int end)
        {
            this.start = start;
            this.end = end;
        }

        public IEnumerable<int> Algorithm()
        {
            ICollection<int> sequence = new List<int>();
            int j = start;
            for (int i = start; i <= end; i += j)
            {
                sequence.Add(i);
                j = i - j;
            }

            return sequence;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace SequenceTask
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

        public IList<int> Algorithm()
        {
            IList<int> sequence = new List<int>();
            int j = 1;
            for (int i = 1; i <= end; i += j)
            {
                sequence.Add(i);
                j = i - j;
            }

            return sequence;
        }
    }
}

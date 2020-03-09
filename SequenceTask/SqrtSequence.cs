using System;
using System.Collections.Generic;
using System.Text;

namespace SequenceTask
{
    class SqrtSequence : ISequent
    {
        private int sqrtNum;

        public SqrtSequence(int num)
        {
            sqrtNum = num;
        }

        IList<int> ISequent.Algorithm()
        {
            IList<int> sequence = new List<int>();
            int x;
            for (int i = 1; (x = i * i) <= sqrtNum; i++)
            {
                sequence.Add(x);
            }

            return sequence;
        }
    }
}

using SequenceTask.Contracts;
using System.Collections.Generic;

namespace SequenceTask.Logic
{
    class SqrtSequence : ISequent
    {
        private int sqrtNum;

        public SqrtSequence(int num)
        {
            sqrtNum = num;
        }

        public IEnumerable<int> Algorithm()
        {
            ICollection<int> sequence = new List<int>();
            int sequentMember;
            for (int i = 1; (sequentMember = i * i) <= sqrtNum; i++)
            {
                sequence.Add(sequentMember);
            }

            return sequence;
        }
    }
}

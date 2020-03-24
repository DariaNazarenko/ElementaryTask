using SequenceTask.Contracts;
using System.Collections.Generic;

namespace SequenceTask.Logic
{
    public class SqrtSequence : ISequenceGenerator
    {
        private int sqrtNum;

        public SqrtSequence(int num)
        {
            sqrtNum = num;
        }

        public IEnumerable<int> GetSequence()
        {
            List<int> sequence = new List<int>();
            int sequentMember;

            for (int i = 0; (sequentMember = i * i) <= sqrtNum; i++)
            {
                sequence.Add(i);
            }

            return sequence;
        }
    }
}

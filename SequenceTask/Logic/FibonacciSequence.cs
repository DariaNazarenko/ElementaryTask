using log4net;
using SequenceTask.Contracts;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace SequenceTask.Logic
{
    public class FibonacciSequence : IGenerator
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        private int start;
        private int end;

        public FibonacciSequence(int start, int end)
        {
            this.start = start;
            this.end = end;
        }

        public IEnumerable<int> GetSequence()
        {
            ICollection<int> sequence = new List<int>();
            if (end != 0)
            {
                int j;
                if (start == 0)
                {
                    sequence.Add(0);
                    j = 1;
                }
                else
                {
                    j = start;
                }

                for (int i = start == 0 ? 1 : start; i <= end; i += j)
                {
                    sequence.Add(i);
                    j = i - j;
                }
                return sequence;
            }
            else if (start == 0)
            {
                sequence.Add(end);
                return sequence;
            }
            else
            {
                log.Error("Invalid input arguments", new ArgumentException());
                throw new ArgumentException("Invalid arguments");
            }
        }
    }
}

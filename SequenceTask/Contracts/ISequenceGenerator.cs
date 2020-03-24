using System.Collections.Generic;

namespace SequenceTask.Contracts
{
    interface ISequenceGenerator
    {
        IEnumerable<int> GetSequence();
    }
}

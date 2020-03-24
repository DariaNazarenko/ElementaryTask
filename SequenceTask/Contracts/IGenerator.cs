using System.Collections.Generic;

namespace SequenceTask.Contracts
{
    interface IGenerator
    {
        IEnumerable<int> GetSequence();
    }
}

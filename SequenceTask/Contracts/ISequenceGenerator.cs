using System.Collections.Generic;

namespace SequenceTask.Contracts
{
    interface ISequenceGenerator
    {
        List<int> GetSequence();
    }
}

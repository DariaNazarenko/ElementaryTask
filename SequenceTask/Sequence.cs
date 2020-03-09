using System;
using System.Collections.Generic;
using System.Text;

namespace SequenceTask
{
    class Sequence
    {
        public Sequence( ISequent seq)
        {
            Sequent = seq;
        }

        public ISequent Sequent { private get; set; }
        public IList<int> Algorithm()
        {
            var seq = Sequent.Algorithm();

            return seq;
        }
    }
}

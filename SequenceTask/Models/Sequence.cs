using SequenceTask.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SequenceTask.Models
{
    class Sequence
    {
        public ISequent Sequent { private get; set; }

        public Sequence( ISequent seq)
        {
            Sequent = seq;
        }

        public IEnumerable<int> Algorithm()
        {
            var seq = Sequent.Algorithm();

            return seq;
        }
    }
}

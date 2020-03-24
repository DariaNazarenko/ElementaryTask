using SequenceTask.Logic;
using System.Collections.Generic;
using Xunit;

namespace SequenceTaskTests
{
    public class SqrtSequenceTests
    {
        [Fact]
        public void Algorithm_CalledWith_0_Ok()
        {
            //arrange
            var sqrtSequence = new SqrtSequence(0);
            IEnumerable<int> expected = new int[] { 0 };

            //act
            var sequence = sqrtSequence.GetSequence();

            //assert
            Assert.Equal(expected, sequence);
        }

        [Fact]
        public void Algorithm_CalledWith_16_Ok()
        {
            //arrange
            var sqrtSequence = new SqrtSequence(16);
            IEnumerable<int> expected = new int[] { 0, 1, 4, 9, 16 };

            //act
            var sequence = sqrtSequence.GetSequence();

            //assert
            Assert.Equal(expected, sequence);
        }
    }
}

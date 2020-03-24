using System.Collections.Generic;
using SequenceTask.Logic;
using System;
using Xunit;

namespace SequenceTaskTests
{
    public class FibonacciSequenceTests
    {
        [Fact]
        public void Algorithm_CalledWith_0_0_Ok()
        {
            //arrange
            var fibonacciSequence = new FibonacciSequence(0, 0);
            IEnumerable<int> expected = new int[] { 0 };

            //act
            var sequence = fibonacciSequence.GetSequence();

            //assert
            Assert.Equal(expected, sequence);
        }

        [Fact]
        public void Algorithm_CalledWith_0_1_Ok()
        {
            //arrange
            var fibonacciSequence = new FibonacciSequence(0, 1);
            IEnumerable<int> expected = new int[] { 0, 1, 1 };

            //act
            var sequence = fibonacciSequence.GetSequence();

            //assert
            Assert.Equal(expected, sequence);
        }

        [Fact]
        public void Algorithm_CalledWith_8_0_ArgumentException()
        {
            //arrange
            var fibonacciSequence = new FibonacciSequence(8, 0);

            //assert
            Assert.Throws<ArgumentException>(() => fibonacciSequence.GetSequence());
        }

        [Fact]
        public void Algorithm_CalledWith_3_8_ArgumentException()
        {
            //arrange
            var fibonacciSequence = new FibonacciSequence(3, 8);
            IEnumerable<int> expected = new int[] { 3, 3, 6 };

            //act
            var sequence = fibonacciSequence.GetSequence();

            //assert
            Assert.Equal(expected, sequence);
        }
    }
}

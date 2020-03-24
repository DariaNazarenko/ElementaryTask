using SequenceTask.Validation;
using Xunit;

namespace ChessTaskTests
{
    public class LocalValidatorTests
    {
        [Fact]
        public void ContainsNegative_CalledWithNegative_True()
        {
            //arrange
            int[] inputArgs = { -1, 2, 3, 4 };
            LocalValidator validator = new LocalValidator();

            //assert
            Assert.True(validator.ContainsNegative(inputArgs));
        }

        [Fact]
        public void ContainsNegative_CalledWithPositive_False()
        {
            //arrange
            int[] inputArgs = { 8, 6, 5 };
            LocalValidator validator = new LocalValidator();

            //assert
            Assert.False(validator.ContainsNegative(inputArgs));
        }
    }
}

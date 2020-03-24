using ChessTask.Validation;
using Xunit;

namespace ChessTaskTests
{
    public class LocalValidatorTests
    {
        [Fact]
        public void CheckParsedArguments_CalledWitNull_False()
        {
            //arrange
            int[] inputArgs = null;
            LocalValidator validator = new LocalValidator();

            //assert
            Assert.False(validator.CheckParsedArguments(inputArgs));
        }

        [Fact]
        public void CheckParsedArguments_CalledWithNegative_False()
        {
            //arrange
            int[] inputArgs = { -8, 6, 5 };
            LocalValidator validator = new LocalValidator();

            //assert
            Assert.False(validator.CheckParsedArguments(inputArgs));
        }
    }
}

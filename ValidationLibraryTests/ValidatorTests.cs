using System;
using Xunit;
using ValidationLibrary;

namespace ValidationLibraryTests
{
    public class ValidatorTests
    {
        [Fact]
        public void ContainsIntNumbers_CalledWithStringArray_True()
        {
            //arrange
            var inputArgs = new String[] { "1255", "0", "-654", "658855" };

            //assert
            Assert.True(Validator.ContainsIntNumbers(inputArgs));
        }

        [Fact]
        public void ContainsIntNumbers_CalledWithStringArrayAndDouble_False()
        {
            //arrange
            var inputArgs = new String[] { "12,55", "text", "-654*", "658,855" };

            //assert
            Assert.False(Validator.ContainsIntNumbers(inputArgs));
        }

        [Fact]
        public void ContainsIntNumbers_CalledWithString_True()
        {
            //arrange
            var inputArgs = "1255";

            //assert
            Assert.True(Validator.ContainsIntNumbers(inputArgs));
        }

        [Fact]
        public void ContainsIntNumbers_CalledWithString_False()
        {
            //arrange
            var inputArgs = "1234text";

            //assert
            Assert.False(Validator.ContainsIntNumbers(inputArgs));
        }

        [Fact]
        public void ContainsDoubleNumbers_CalledWithStringArray_True()
        {
            //arrange
            var inputArgs = new String[] { "12,55", "0", "-654", "658,855" };

            //assert
            Assert.True(Validator.ContainsDoubleNumbers(inputArgs));
        }

        [Fact]
        public void ContainsDoubleNumbers_CalledWithStringArray_False()
        {
            //arrange
            var inputArgs = new String[] { "1255", "0", "-654", "658855" };

            //assert
            Assert.False(Validator.ContainsDoubleNumbers(inputArgs));
        }

        [Fact]
        public void ContainsDoubleNumbers_CalledWithString_True()
        {
            //arrange
            var inputArgs =  "12,55";

            //assert
            Assert.True(Validator.ContainsDoubleNumbers(inputArgs));
        }

        [Fact]
        public void ContainsDoubleNumbers_CalledWithString_False()
        {
            //arrange
            var inputArgs = "345.ffdsj78";

            //assert
            Assert.False(Validator.ContainsDoubleNumbers(inputArgs));
        }
    }
}

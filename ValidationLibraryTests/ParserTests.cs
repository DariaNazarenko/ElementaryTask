using System;
using Xunit;
using ValidationLibrary;

namespace ValidationLibraryTests
{
    public class ParserTests
    {
        [Fact]
        public void GetIntegerArray_CalledWithSymbols_Null()
        {
            //arrange
            var inputArgs = new String[] { "sfd", "gshf" };
            var parser = new Parser();
            int[] expected = null;

            //act
            var parsed = parser.GetIntegerArray(inputArgs);

            //assert
            Assert.Equal(expected, parsed);
        }

        [Fact]
        public void GetIntegerArray_CalledWithNegative_Ok()
        {
            //arrange
            var inputArgs = new String[] { "-5", "6" };
            var parser = new Parser();
            int[] expected = { -5, 6 };

            //act
            var parsed = parser.GetIntegerArray(inputArgs);

            //assert
            Assert.Equal(expected, parsed);
        }

        [Fact]
        public void GetIntegerArray_CalledWithDouble_Null()
        {
            //arrange
            var inputArgs = new String[] { "5,2", "6" };
            var parser = new Parser();
            int[] expected = null;

            //act
            var parsed = parser.GetIntegerArray(inputArgs);

            //assert
            Assert.Equal(expected, parsed);
        }

        [Fact]
        public void GetIntegerArray_CalledWithInteger_Ok()
        {
            //arrange
            var inputArgs = new String[] { "5", "6" };
            var parser = new Parser();
            int[] expected = { 5, 6 };

            //act
            var parsed = parser.GetIntegerArray(inputArgs);

            //assert
            Assert.Equal(expected, parsed);
        }

        [Fact]
        public void GetDoubleArray_CalledWithSymbols_Null()
        {
            //arrange
            var inputArgs = new String[] { "sfd", "gshf" };
            var parser = new Parser();
            double[] expected = null;

            //act
            var parsed = parser.GetDoubleArray(inputArgs);

            //assert
            Assert.Equal(expected, parsed);
        }

        [Fact]
        public void GetDoubleArray_CalledWithNegative_Ok()
        {
            //arrange
            var inputArgs = new String[] { "-5", "6" };
            var parser = new Parser();
            double[] expected = { -5.0, 6.0 };

            //act
            var parsed = parser.GetDoubleArray(inputArgs);

            //assert
            Assert.Equal(expected, parsed);
        }

        [Fact]
        public void GetDoubleArray_CalledWithDouble_Ok()
        {
            //arrange
            var inputArgs = new String[] { "5,2", "6,2" };
            var parser = new Parser();
            double[] expected = { 5.2, 6.2 };

            //act
            var parsed = parser.GetDoubleArray(inputArgs);

            //assert
            Assert.Equal(expected, parsed);
        }

        [Fact]
        public void GetDoubleArray_CalledWithInteger_Ok()
        {
            //arrange
            var inputArgs = new String[] { "5", "6" };
            var parser = new Parser();
            double[] expected = { 5.0, 6.0 };

            //act
            var parsed = parser.GetDoubleArray(inputArgs);

            //assert
            Assert.Equal(expected, parsed);
        }

        [Fact]
        public void GetIntegerValue_CalledWithSymbols_0()
        {
            //arrange
            var inputStr = "sfd";
            var parser = new Parser();
            int expected = 0;

            //act
            var parsed = parser.GetIntegerValue(inputStr);

            //assert
            Assert.Equal(expected, parsed);
        }

        [Fact]
        public void GetIntegerValue_CalledWithNegative_Ok()
        {
            //arrange
            var inputStr = "-5";
            var parser = new Parser();
            int expected = -5;

            //act
            var parsed = parser.GetIntegerValue(inputStr);

            //assert
            Assert.Equal(expected, parsed);
        }

        [Fact]
        public void GetIntegerValue_CalledWithDouble_0()
        {
            //arrange
            var inputStr = "5,2";
            var parser = new Parser();
            int expected = 0;

            //act
            var parsed = parser.GetIntegerValue(inputStr);

            //assert
            Assert.Equal(expected, parsed);
        }

        [Fact]
        public void GetIntegerValue_CalledWithInteger_Ok()
        {
            //arrange
            var inputStr = "5";
            var parser = new Parser();
            int expected = 5;

            //act
            var parsed = parser.GetIntegerValue(inputStr);

            //assert
            Assert.Equal(expected, parsed);
        }

        [Fact]
        public void GetAppropriateStringArray_CalledWithNumbersAndString_Ok()
        {
            //arrange
            var inputStr = "5,2,name,7";
            var parser = new Parser();
            string[] expected = { "5", "2", "name", "7" };

            //act
            var parsed = parser.GetAppropriateStringArray(inputStr);

            //assert
            Assert.Equal(expected, parsed);
        }

        [Fact]
        public void GetAppropriateStringArray_CalledWithSpaces_Ok()
        {
            //arrange
            var inputStr = "5,2,name      ,7";
            var parser = new Parser();
            string[] expected = { "5", "2", "name", "7" };

            //act
            var parsed = parser.GetAppropriateStringArray(inputStr);

            //assert
            Assert.Equal(expected, parsed);
        }

        [Fact]
        public void RemoveSpaces_CalledWithSpaces_Ok()
        {
            //arrange
            var inputStr = "5   ,   2,name      ,7";
            var parser = new Parser();
            string expected = "5,2,name,7";

            //act
            var parsed = parser.RemoveSpaces(inputStr);

            //assert
            Assert.Equal(expected, parsed);
        }

        [Fact]
        public void ChangeDots_CalledWithSpaces_Ok()
        {
            //arrange
            var inputStr = "2.8,o";
            var parser = new Parser();
            string expected = "2,8,o";

            //act
            var parsed = parser.ChangeDots(inputStr);

            //assert
            Assert.Equal(expected, parsed);
        }
    }
}

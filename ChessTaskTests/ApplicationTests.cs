using ChessTask.ChessApp;
using System;
using Xunit;

namespace ChessTaskTests
{
    public class ApplicationTests
    {
        [Fact]
        public void Run_CalledWithString_ArgumentException()
        {
            //Arrange
            var app = new Application();
            var inputArgs = new string[] { "df", "fh" };

            //Assert
            Assert.Throws<ArgumentException>(() => app.Run(inputArgs));
        }

        [Fact]
        public void Run_CalledWithNotEnoughArguments_ArgumentException()
        {
            //Arrange
            var app = new Application();
            var inputArgs = new string[] { "5" };

            //Assert
            Assert.Throws<ArgumentException>(() => app.Run(inputArgs));
        }

        [Fact]
        public void Run_CalledWithManyArguments_ArgumentException()
        {
            //Arrange
            var app = new Application();
            var inputArgs = new string[] { "5", "7", "7" };

            //Assert
            Assert.Throws<ArgumentException>(() => app.Run(inputArgs));
        }

        [Fact]
        public void Run_CalledWithoutArguments_ArgumentException()
        {
            //Arrange
            var app = new Application();
            var inputArgs = new string[] {};

            //Assert
            Assert.Throws<ArgumentException>(() => app.Run(inputArgs));
        }

        [Fact]
        public void Run_CalledWithDouble_ArgumentException()
        {
            //Arrange
            var app = new Application();
            var inputArgs = new string[] { "2,5", "3,0" };

            //Assert
            Assert.Throws<ArgumentException>(() => app.Run(inputArgs));
        }

        [Fact]
        public void Run_CalledWithNegative_ArgumentException()
        {
            //Arrange
            var app = new Application();
            var inputArgs = new string[] { "-5", "-6" };

            //Assert
            Assert.Throws<ArgumentException>(() => app.Run(inputArgs));
        }

        //[Fact]
        //public void Run_CalledWithOKArguments_Ok()
        //{
        //    //Arrange
        //    var app = new Application();
        //    var inputArgs = new string[] { "5", "7" };
        //    var expected = new Board(5, 7);

        //    //Act
        //    app.Run(inputArgs);

        //    //Assert
        //    Assert.Equal(expected, app.board);
        //}
    }
}

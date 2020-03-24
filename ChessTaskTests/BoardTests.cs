using ChessTask.Logic;
using Xunit;

namespace ChessTaskTests
{
    public class BoardTests
    {
        [Fact]
        public void SetBoard_CalledWithEvenWidth_OK()
        {
            //arrange
            const int width = 4;
            const int height = 2;
            var expected = new char[height, width] { {'*', ' ', '*', ' '},
                                                     {' ', '*', ' ', '*'}};

            //act
            var board = new Board(width, height);

            //assert
            for (int i = 0; i < board.Height; i++)
            {
                for (int j = 0; j < board.Width; j++)
                {
                    Assert.Equal(expected[i,j], board[i,j]);
                }
            }
        }

        [Fact]
        public void SetBoard_CalledWithOddWidth_OK()
        {
            //arrange
            const int width = 5;
            const int height = 2;
            var expected = new char[height, width] { {'*', ' ', '*', ' ', '*'},
                                                     {' ', '*', ' ', '*', ' '}};

            //act
            var board = new Board(width, height);

            //assert
            for (int i = 0; i < board.Height; i++)
            {
                for (int j = 0; j < board.Width; j++)
                {
                    Assert.Equal(expected[i, j], board[i, j]);
                }
            }
        }

        [Fact]
        public void SetBoard_CalledWith0Width_OK()
        {
            //arrange
            const int width = 0;
            const int height = 2;
            var expected = new char[height, width] { {},
                                                     {}};

            //act
            var board = new Board(width, height);

            //assert
            for (int i = 0; i < board.Height; i++)
            {
                for (int j = 0; j < board.Width; j++)
                {
                    Assert.Equal(expected[i, j], board[i, j]);
                }
            }
        }
    }
}

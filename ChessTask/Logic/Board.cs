using ChessTask.Contracts;
using ChessTask.Models;

namespace ChessTask.Logic
{
    class Board : IDrawable
    {
        public int Width { get; private set; }
        public int Height { get; private set; }
        private Cell[,] board;

        public char this[int i, int j]
        {
            get => board[i, j].Value;
        }

        public Board(int width, int height)
        {
            this.Width = width;
            this.Height = height;
            board = SetBoard();
        }

        private Cell[,] SetBoard()
        {
            board = new Cell[Height, Width];

            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    if (i % 2 == 0)
                    {
                        board[i, j] = SetEvenRow(j);
                    }
                    else
                    {
                        board[i, j] = SetOddRow(j);
                    }
                }
            }

            return board;
        }

        private Cell SetEvenRow(int column)
        {
            if (column % 2 == 0)
            {
                return new Black();
            }
            else
            {
                return new White();
            }
        }

        private Cell SetOddRow(int column)
        {
            if (column % 2 == 0)
            {
                return new White();
            }
            else
            {
                return new Black();
            }
        }
    }
}

using ChessTask.Contracts;
using ChessTask.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChessTask.Logic
{
    class Board : IDrawable
    {
        public int Width { get; private set; }
        public int Height { get; private set; }
        private Cell[,] board;

        public char this[int i, int j]
        {
            get => board[i,j].Value;
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
                        if (j % 2 == 0)
                        {
                            board[i, j] = new Black();
                        }
                        else
                        {
                            board[i, j] = new White();
                        }
                    }
                    else
                    {
                        if (j % 2 == 0)
                        {
                            board[i, j] = new White();
                        }
                        else
                        {
                            board[i, j] = new Black();
                        }
                    }
                }
            }

            return board;
        }
    }
}

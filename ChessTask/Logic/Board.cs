using ChessTask.Contracts;
using ChessTask.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChessTask.Logic
{
    class Board : IDrawable
    {
        private int width;
        private int height;
        private Cell[,] board;

        public Board(int width, int height)
        {
            this.width = width;
            this.height = height;
            board = SetBoard();
        }

        private Cell[,] SetBoard()
        {
            board = new Cell[height, width];
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
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

        public void Draw()
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(board[i, j].Value);
                }
                Console.WriteLine();
            }
        }
    }
}

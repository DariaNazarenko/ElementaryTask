using System;
using System.Collections.Generic;
using System.Text;

namespace ChessTask.Logic
{
    class Board
    {
        private int width;
        private int height;

        public Board(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public Cell[,] SetBoard()
        {
            Cell[,] board = new Cell[height, width];
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

        public void DrawBoard(Cell[,] board)
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

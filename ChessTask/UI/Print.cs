using ChessTask.Logic;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChessTask.UI
{
    class Print
    {
        public void PrintBoard(Board board)
        {
            for (int i = 0; i < board.Height; i++)
            {
                for (int j = 0; j < board.Width; j++)
                {
                    Console.Write(board[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}

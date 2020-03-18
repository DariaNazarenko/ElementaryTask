using ChessTask.Logic;
using System;

namespace ChessTask.UI
{
    static class Print
    {
        public static void PrintBoard(Board board)
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

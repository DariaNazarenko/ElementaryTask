using ValidationLibrary;
using ChessTask.Logic;
using ChessTask.UI;
using System;

namespace ChessTask.ChessApp
{
    static class Application
    {
        public static void Run(string[] args)
        {
            var array = Parser.GetIntegerArray(args);
            if (array != null)
            {
                Board board = new Board(array[0], array[1]);
                Print.PrintBoard(board);
            }
            else
            {
                Console.WriteLine("Invalid input string");
            }
        }
    }
}

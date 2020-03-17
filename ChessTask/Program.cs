using ChessTask.Logic;
using ChessTask.UI;
using System;
using ValidationLibrary;

namespace ChessTask
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var array = new Validator(args).GetIntegerArray();
                if (array != null)
                {
                    Board b = new Board(array[0], array[1]);
                    new Print().PrintBoard(b);
                }
                else
                {
                    Console.WriteLine("Invalid input string");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }       
        }
    }
}

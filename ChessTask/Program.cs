using ChessTask.Logic;
using ChessTask.Validation;
using System;

namespace ChessTask
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var array = new Validate(args).GetIntegerArray();
                if (array != null)
                {
                    Board b = new Board(array[0], array[1]);
                    b.Draw();
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

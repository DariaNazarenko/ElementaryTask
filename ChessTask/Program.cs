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
                var array = new Valid(args).GetInegerArray();
                Board b = new Board(array[0], array[1]);
                b.DrawBoard(b.SetBoard());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
           
        }
    }
}

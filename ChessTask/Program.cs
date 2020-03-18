using ChessTask.ChessApp;
using System;

namespace ChessTask
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Application.Run(args);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }       
        }
    }
}

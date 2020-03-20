using ValidationLibrary;
using ChessTask.Logic;
using ChessTask.UI;
using System;
using log4net;
using System.Reflection;

namespace ChessTask.ChessApp
{
    static class Application
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public static void Run(string[] args)
        {
            var array = Parser.GetIntegerArray(args);

            if (array != null && array.Length == 2)
            {
                Board board = new Board(array[0], array[1]);
                Print.PrintBoard(board);
                log.Info("Input string was validated.");
            }
            else
            {
                log.Error(new ArgumentException().Message);
                throw new ArgumentException("Invalid input string!");                
            }
        }
    }
}

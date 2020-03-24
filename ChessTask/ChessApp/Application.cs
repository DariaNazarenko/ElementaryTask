using ValidationLibrary;
using ChessTask.Logic;
using ChessTask.UI;
using System;
using log4net;
using System.Reflection;
using ChessTask.Validation;

namespace ChessTask.ChessApp
{
    public class Application
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        private Parser parser;
        private LocalValidator localValidator;

        public Application()
        {
            parser = new Parser();
            localValidator = new LocalValidator();
        }

        public void Run(string[] args)
        {
            var array = parser.GetIntegerArray(args);

            if (localValidator.CheckParsedArguments(array))
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

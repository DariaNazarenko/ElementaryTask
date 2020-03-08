using System;

namespace ChessTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Validation(args).GetBoard();
            var cells = board.GetCells();
            board.Draw(cells);
        }
    }
}

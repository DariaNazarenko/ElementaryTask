using System;
using System.Collections.Generic;
using System.Text;

namespace ChessTask
{
    class EvenBoard : Board
    {
        public EvenBoard(int width, int height) : base(width, height)
        {

        }

        public override Cell[] GetCells()
        {
            int count = 0;
            Cell[] chessBoard = new Cell[(width * height) + height];
            for (int i = 0; i < chessBoard.Length; i++)
            {
                if (count == width)
                {
                    chessBoard[i] = new Cell('\n');
                    count = 0;
                }
                else
                {
                    if (i % 2 == 0)
                    {
                        chessBoard[i] = new Cell('*');
                        count++;
                    }
                    else if (i % 2 != 0)
                    {
                        chessBoard[i] = new Cell(' ');
                        count++;
                    }
                }
            }

            return chessBoard;
        }
    }
}

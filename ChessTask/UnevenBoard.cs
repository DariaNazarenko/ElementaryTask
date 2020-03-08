using System;
using System.Collections.Generic;
using System.Text;

namespace ChessTask
{
    class UnevenBoard : Board
    {
        public UnevenBoard(int width, int height) : base(width, height)
        {

        }

        public override Cell[] GetCells()
        {
            int count = 0;
            Cell[] chessBoard = new Cell[(width * height) + height - 1];
            for (int i = 0; i < chessBoard.Length; i++)
            {
                if (count == width)
                {
                    chessBoard[i] = new Cell('\n');
                    count = 0;
                }
                else
                {
                    if (i == 0)
                    {
                        chessBoard[i] = new Cell('*');
                        count++;
                    }
                    else if (chessBoard[i - 1].Value == ' ')
                    {
                        chessBoard[i] = new Cell('*');
                        count++;
                    }
                    else if (chessBoard[i - 1].Value == '*')
                    {
                        chessBoard[i] = new Cell(' ');
                        count++;
                    }
                    else if(chessBoard[i - 1].Value == '\n')
                    {
                        if(chessBoard[i - 2].Value == '*')
                        {
                            chessBoard[i] = new Cell(' ');
                            count++;
                        }
                        else if (chessBoard[i - 2].Value == ' ')
                        {
                            chessBoard[i] = new Cell('*');
                            count++;
                        }
                    }
                }
            }

            return chessBoard;
        }

    }
}

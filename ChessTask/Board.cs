using System;
using System.Collections.Generic;
using System.Text;

namespace ChessTask
{
    abstract class Board : IDrawable
    {
        protected int width;
        protected int height;

        public Board(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public void Draw(Cell[] cells)
        {
            foreach (var item in cells)
            {
                Console.Write(item.Value);
            }
        }

        public abstract Cell[] GetCells();
    }
}

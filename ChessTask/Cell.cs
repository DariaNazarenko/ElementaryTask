using System;
using System.Collections.Generic;
using System.Text;

namespace ChessTask
{
    class Cell
    {
        public char Value { get; private set; }
        public Cell(char value)
        {
            Value = value;
        }
    }
}

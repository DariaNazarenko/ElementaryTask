using ChessTask.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChessTask.Contracts
{
    interface IDrawable
    {
        char this[int i, int j]
        {
            get;
        }
    }
}

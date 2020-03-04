using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace TriangleTask
{
    class SpecialComparer: IComparer<double>
    {
        public int Compare([AllowNull] double x, [AllowNull] double y)
        {
            if (x < y)
                return 1;
            if (x > y)
                return -1;
            else return 0;
        }
    }
}

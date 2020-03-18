using System;
using System.Collections;

namespace TriangleTask.UI
{
    class Print
    {
        public static void PrintTriangles(IEnumerable orderedTriangles)
        {
            foreach (var item in orderedTriangles)
            {
                Console.WriteLine(item);
            }
        }
    }
}

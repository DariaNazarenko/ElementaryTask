using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace EnvelopeTask.Validation
{
    class DoubleArray
    {
        public double[] ToDoubleArray(string[] str)
        {
            double[] doubleArray = null;
            if (str.Length == 4)
            {
                doubleArray = str.Select(s => double.Parse(s)).ToArray();
            }

            return doubleArray;
        }
    }
}

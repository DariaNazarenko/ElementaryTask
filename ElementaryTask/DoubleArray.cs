using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace EnvelopeTask
{
    class DoubleArray
    {
        public double[] ToDoubleArray(string[] str)
        {
			double[] doubleArray=null;
			if (str.Length == 4)
			{
				try
				{
					doubleArray = str.Select(s => double.Parse(s)).ToArray();
				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
				}
			}
            return doubleArray;
        }
	}
}

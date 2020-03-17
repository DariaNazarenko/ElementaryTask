using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace ValidationLibrary
{
    public class Validator
    {
        private string[] inputArgs;
        public Validator(string[] input)
        {
            inputArgs = input;
        }

        public int[] GetIntegerArray()
        {
            int[] intArray = null;

            if (!ContainsNotNumbers())
            {
                intArray = inputArgs.Select(s => Int32.Parse(s)).ToArray();
            }

            return intArray;
        }

        public double[] GetDoubleArray()
        {
            double[] doubleArray = null;

            if (!ContainsNotNumbers())
            {
                doubleArray = inputArgs.Select(s => double.Parse(s)).ToArray();
            }

            return doubleArray;
        }

        private bool ContainsNotNumbers()
        {
            const string NotNumberPattern = @"\D+";
            Regex regex = new Regex(NotNumberPattern);

            foreach (var item in inputArgs)
            {
                if (regex.IsMatch(item))
                {
                    return true;
                }
            }

            return false;
        }
    }
}

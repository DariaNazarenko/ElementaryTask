using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace EnvelopeTask.Validation
{
    class Validate
    {
        private string[] inputArgs;
        public Validate(string[] input)
        {
            inputArgs = input;
        }

        public double[] ToDoubleArray()
        {
            double[] doubleArray = null;
            if (inputArgs.Length == 4 && !ContainsNotNumbers())
            {
                doubleArray = inputArgs.Select(s => double.Parse(s)).ToArray();
            }

            return doubleArray;
        }

        private bool ContainsNotNumbers()
        {
            string NotNumberPattern = @"\D+";
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

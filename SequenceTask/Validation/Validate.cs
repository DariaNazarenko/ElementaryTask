using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace SequenceTask.Validation
{
    class Validate
    {
        private string[] inputArgs;
        public Validate(string[] input)
        {
            inputArgs = input;
        }

        public int[] ToIntArray()
        {
            int[] intArray = null;
            if ((inputArgs.Length == 2 || inputArgs.Length == 3) && !ContainsNotNumbers())
            {
                intArray = inputArgs.Select(s => Int32.Parse(s)).ToArray();
            }

            return intArray;
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

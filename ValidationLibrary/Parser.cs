using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace ValidationLibrary
{
    public class Parser
    {
        public int[] GetIntegerArray(string[] inputArgs)
        {
            int[] intArray = null;

            if (Validator.ContainsIntNumbers(inputArgs) && !Validator.ContainsDoubleNumbers(inputArgs))
            {
                intArray = inputArgs.Select(s => Int32.Parse(s)).ToArray();
            }

            return intArray;
        }

        public double[] GetDoubleArray(string[] inputArgs)
        {
            double[] doubleArray = null;

            if (Validator.ContainsIntNumbers(inputArgs) || Validator.ContainsDoubleNumbers(inputArgs))
            {
                doubleArray = inputArgs.Select(s => double.Parse(s)).ToArray();
            }

            return doubleArray;
        }

        public int GetIntegerValue(string inputArgs)
        {
            int integerValue = 0;

            if (Validator.ContainsIntNumbers(inputArgs) && !Validator.ContainsDoubleNumbers(inputArgs))
            {
                integerValue = Int32.Parse(inputArgs);
            }

            return integerValue;
        }

        public string[] GetAppropriateStringArray(string inputString)
        {
            inputString = RemoveSpaces(inputString);

            string[] StringArray = inputString.Split(',');

            return StringArray;
        }

        public string RemoveSpaces(string inputString)
        {
            const string SpacePattern = @"\s+";
            Regex regex = new Regex(SpacePattern);
            inputString = regex.Replace(inputString, string.Empty);

            return inputString;
        }

        public string ChangeDots(string inputString)
        {
            const string DotPattern = @"\.";
            Regex regex = new Regex(DotPattern);

            return regex.Replace(inputString, ",");
        }
    }
}

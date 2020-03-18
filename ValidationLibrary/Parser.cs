using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ValidationLibrary
{
    public static class Parser
    {
        public static int[] GetIntegerArray(string[] inputArgs)
        {
            int[] intArray = null;

            if (!Validator.ContainsNotNumbers(inputArgs))
            {
                intArray = inputArgs.Select(s => Int32.Parse(s)).ToArray();
            }

            return intArray;
        }

        public static double[] GetDoubleArray(string[] inputArgs)
        {
            double[] doubleArray = null;

            if (!Validator.ContainsNotNumbers(inputArgs))
            {
                doubleArray = inputArgs.Select(s => double.Parse(s)).ToArray();
            }

            return doubleArray;
        }

        public static int GetIntegerValue(string[] inputArgs)
        {
            int integerValue = 0;

            if (!Validator.ContainsNotNumbers(inputArgs))
            {
                integerValue = Int32.Parse(inputArgs[0]);
            }

            return integerValue;
        }

        public static string[] GetAppropriateStringArray(string inputString)
        {
            const string DotPattern = @"\.";
            Regex regex = new Regex(DotPattern);

            RemoveSpaces(inputString);
           
            string[] StringArray = inputString.Split(',');
            for (int i = 0; i < StringArray.Length; i++)
            {
                StringArray[i] = regex.Replace(StringArray[i], ",");
            }

            return StringArray;
        }

        public static string RemoveSpaces(string inputString)
        {
            const string SpacePattern = @"\s+";
            Regex regex = new Regex(SpacePattern);
            inputString = regex.Replace(inputString, string.Empty);

            return inputString;
        }
    }
}

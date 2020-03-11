using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace TriangleTask.Validation
{
    class CheckInputString
    {
        private string inputString;
        public CheckInputString(string str)
        {
            inputString = str;
        }
        public string[] GetAppropriateStringArray()
        {
            string SpacePattern = @"\s+";
            Regex regex = new Regex(SpacePattern);
            inputString = regex.Replace(inputString, string.Empty);
            string DotPattern = @"\.";
            regex = new Regex(DotPattern);
            string[] StringArray = inputString.Split(',');
            for (int i = 0; i < StringArray.Length; i++)
            {
                StringArray[i] = regex.Replace(StringArray[i], ",");
            }

            return StringArray;
        }
    }
}

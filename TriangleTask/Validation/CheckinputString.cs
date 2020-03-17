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
            const string SpacePattern = @"\s+";
            const string DotPattern = @"\.";

            Regex regex = new Regex(SpacePattern);
            inputString = regex.Replace(inputString, string.Empty);
            
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

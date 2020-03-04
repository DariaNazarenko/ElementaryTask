using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace TriangleTask
{
    class CheckInputString
    {
        public string[] GetAppropriateStringArray(string str)
        {
            string pattern = @"\s+";
            Regex regex = new Regex(pattern);
            str = regex.Replace(str, string.Empty);
            return str.Split(',');
        }
    }
}

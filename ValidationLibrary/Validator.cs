using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace ValidationLibrary
{
    public static class Validator
    {
        public static bool ContainsNotNumbers(string[] inputArgs)
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

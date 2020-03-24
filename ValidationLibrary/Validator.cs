using System.Text.RegularExpressions;

namespace ValidationLibrary
{
    public static class Validator
    {
        public static bool ContainsIntNumbers(string[] inputArgs)
        {
            const string onlyNumberPattern = @"^-?\d+$";
            Regex regex = new Regex(onlyNumberPattern);

            foreach (var item in inputArgs)
            {
                if (!regex.IsMatch(item))
                {
                    return false;
                }
            }

            return true;
        }

        public static bool ContainsDoubleNumbers(string[] inputArgs)
        {
            const string doublePattern = @"^-?\d+\,\d+$";
            Regex regex = new Regex(doublePattern);

            foreach (var item in inputArgs)
            {
                if (regex.IsMatch(item))
                {
                    return true;
                }
            }

            return false;
        }

        public static bool ContainsIntNumbers(string inputArgs)
        {
            const string onlyNumberPattern = @"^-?\d+$";
            Regex regex = new Regex(onlyNumberPattern);

            if (!regex.IsMatch(inputArgs))
            {

                return false;
            }

            return true;
        }

        public static bool ContainsDoubleNumbers(string inputArgs)
        {
            const string doublePattern = @"^-?\d+\,\d+$";
            Regex regex = new Regex(doublePattern);

            if (regex.IsMatch(inputArgs))
            {
                return true;
            }

            return false;
        }
    }
}

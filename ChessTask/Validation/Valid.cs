using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChessTask.Validation
{
    class Valid
    {
        private string[] inputArgs;
        public Valid(string[] input)
        {
            inputArgs = input;
        }

        public int[] GetInegerArray()
        {
            int[] intArray = null;

            if (inputArgs.Length == 2)
            {
                intArray = inputArgs.Select(s => Int32.Parse(s)).ToArray();
            }

            return intArray;
        }
    }
}

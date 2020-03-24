using System;
using System.Collections.Generic;
using System.Text;

namespace ChessTask.Validation
{
    public class LocalValidator
    {
        public bool CheckParsedArguments(int[] array)
        {
            if (array == null || ContainsNegative(array))
            {
                return false;
            }
            else
            {
                return (array.Length == 2 && array[0] <= Console.WindowWidth);
            }
        }

        public bool ContainsNegative(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {

                    return true;
                }
            }

            return false;
        }
    }
}

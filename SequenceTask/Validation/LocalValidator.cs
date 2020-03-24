using System;
using System.Collections.Generic;
using System.Text;

namespace SequenceTask.Validation
{
    public class LocalValidator
    {
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

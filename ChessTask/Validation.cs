using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChessTask
{
    class Validation
    {
        private string[] inputArgs;
        public Validation(string[] input)
        {
            inputArgs = input;
        }

        private int[] GetInegerArray()
        {
            int[] intArray = null;

            if (inputArgs.Length == 2)
            {
                try
                {
                    intArray = inputArgs.Select(s => Int32.Parse(s)).ToArray();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            return intArray;
        }

        public Board GetBoard()
        {
            int[] WidthHeightArr = GetInegerArray();
            if (WidthHeightArr[0] % 2 == 0)
            {
                return new EvenBoard(WidthHeightArr[0], WidthHeightArr[1]);
            }
            else
            {
                return new UnevenBoard(WidthHeightArr[0], WidthHeightArr[1]);
            }
        }
    }
}

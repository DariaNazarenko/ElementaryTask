using WriteNumberTask.Contracts;
using WriteNumberTask.Models;

namespace WriteNumberTask.Logic
{
    class UnitWriter : IWriter
    {
        public string Write(Numeric number)
        {
            string num = string.Empty;

            if (number.Number >= 1)
            {
                var units = number.Number % 10;

                if (units != 0)
                {
                    num = new NumberInWords().vocabulary[units];
                }
            }
            else if(number.Number == 0)
            {
                num = new NumberInWords().vocabulary[number.Number];
            }

            return num;
        }
    }
}

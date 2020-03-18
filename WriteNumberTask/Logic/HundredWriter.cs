using WriteNumberTask.Contracts;
using WriteNumberTask.Models;

namespace WriteNumberTask.Logic
{
    class HundredWriter : IWriter
    {
        public string Write(Numeric number)
        {
            string num = string.Empty;

            if (number.Number >= 100)
            {
                var hundreds = (number.Number % 1000) - (number.Number % 100);

                if (hundreds != 0)
                {
                    num = new NumberInWords().vocabulary[hundreds];
                }
            }

            return num;
        }
    }
}

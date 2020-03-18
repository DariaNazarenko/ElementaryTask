using WriteNumberTask.Contracts;
using WriteNumberTask.Models;

namespace WriteNumberTask.Logic
{
    class DozenWriter : IWriter
    {
        public string Write(Numeric number)
        {
            string num = string.Empty;

            if (number.Number >= 10)
            {
                var dozens = (number.Number % 100) - (number.Number % 10);

                if (dozens != 0)
                {
                    num = new NumberInWords().vocabulary[dozens];
                }
            }

            return num;
        }
    }
}

using WriteNumberTask.Contracts;
using WriteNumberTask.Models;

namespace WriteNumberTask.Logic
{
    class DozenThousendWriter : IWriter
    {
        public string Write(Numeric number)
        {
            string num = string.Empty;

            if (number.Number >= 10000 && number.Number < 20000)
            {
                var dozenThousands = (number.Number % 100000) - (number.Number % 1000);

                if (dozenThousands != 0)
                {
                    num = new NumberInWords().vocabulary[dozenThousands];
                }
            }
            else
            {
                var dozenThousands = (number.Number % 100000) - (number.Number % 10000);

                if (dozenThousands != 0)
                {
                    num = new NumberInWords().vocabulary[dozenThousands];
                }
            }

            return num;
        }
    }
}

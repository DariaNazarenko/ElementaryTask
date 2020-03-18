using WriteNumberTask.Contracts;
using WriteNumberTask.Models;

namespace WriteNumberTask.Logic
{
    class ThousandWriter : IWriter
    {
        public string Write(Numeric number)
        {
            string num = string.Empty;

            if(number.Number >= 1000 && number.Number < 10000)
            {
                var thousands = (number.Number % 10000) - (number.Number % 1000);

                if(thousands != 0)
                {
                    num = new NumberInWords().vocabulary[thousands];
                }               
            }
            else if(number.Number >= 20000)
            {
                var thousands = (number.Number % 10000) - (number.Number % 1000);

                if (thousands != 0)
                {
                    num = new NumberInWords().vocabulary[thousands];
                }
                else
                {
                    num = new NumberInWords().vocabulary[-1000];
                }
            }

            return num;
        }
    }
}

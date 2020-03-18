using WriteNumberTask.Contracts;
using WriteNumberTask.Models;

namespace WriteNumberTask.Logic
{
    class NumberConvertor
    {
        private readonly IWriter[] numberParts;

        public NumberConvertor()
        {
            numberParts = new IWriter[]
            {
                new DozenThousendWriter(),
                new ThousandWriter(),
                new HundredWriter(),
                new DozenWriter(),
                new UnitWriter(),
            };
        }

        public string WriteNumber(Numeric number)
        {
            var numberInWords = string.Empty;

            foreach (var item in numberParts)
            {
                var part = item.Write(number);

                numberInWords += part;

                if (part != string.Empty)
                    numberInWords += " ";
            }

            return numberInWords;
        }
    }
}

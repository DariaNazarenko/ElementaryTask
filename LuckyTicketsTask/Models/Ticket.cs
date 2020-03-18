using System;
using System.Linq;

namespace LuckyTicketsTask.Models
{
    class Ticket
    {
        private int[] number;
        public int Length { get => number.Length; }

        public int this[int i]
        {
            get => number[i];
        }

        public Ticket(string number)
        {
            this.number = GetIntegerArray(number);
        }

        private int[] GetIntegerArray(string number)
        {

            return number.ToString().ToCharArray().Select(s => Int32.Parse(s.ToString())).ToArray();
        }
    }
}

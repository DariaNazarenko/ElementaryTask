using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace LuckyTicketsTask.Models
{
    class Ticket
    {
        public int[] Number { get; private set; }

        public Ticket(string number)
        {
            Number = GetInegerArray(number);
        }

        private int[] GetInegerArray(string number)
        {

            return number.ToString().ToCharArray().Select(s => Int32.Parse(s.ToString())).ToArray();
        }
    }
}

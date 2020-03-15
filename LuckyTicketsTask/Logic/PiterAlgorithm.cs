using LuckyTicketsTask.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LuckyTicketsTask.Logic
{
    class PiterAlgorithm : LuckyTicketAlgorithm
    {
        public override bool IsLucky(int ticket)
        {
            var sumOfEven = SumOfEven(new Ticket(ticket.ToString()).Number);
            var sumOfOdd = SumOfOdd(new Ticket(ticket.ToString()).Number);

            return (sumOfEven == sumOfOdd) ? true : false;
        }

        private int SumOfEven(int[] array)
        {
            var sum = 0;

            for (int i = 1; i < array.Length; i += 2)
            {
                sum += array[i];
            }

            return sum;
        }

        private int SumOfOdd(int[] array)
        {
            var sum = 0;

            for (var i = 0; i < array.Length; i += 2)
            {
                sum += array[i];
            }

            return sum;
        }
    }
}

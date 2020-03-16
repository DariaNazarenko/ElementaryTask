using LuckyTicketsTask.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LuckyTicketsTask.Logic
{
    class PiterAlgorithm : LuckyTicketAlgorithm
    {
        public override bool IsLucky(Ticket ticket)
        {
            var sumOfEven = SumOfEven(ticket.Number);
            var sumOfOdd = SumOfOdd(ticket.Number);

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

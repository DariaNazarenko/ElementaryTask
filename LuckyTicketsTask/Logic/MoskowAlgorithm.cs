using LuckyTicketsTask.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LuckyTicketsTask.Logic
{
    class MoskowAlgorithm : LuckyTicketAlgorithm
    {
        private readonly int CountOfNumbers = 6;

        public override bool IsLucky(Ticket ticket)
        {
            int FirstPartSum = SumOfTicketNumbers(ticket.Number, 0, CountOfNumbers / 2);
            int SecondPartSum = SumOfTicketNumbers(ticket.Number, CountOfNumbers / 2, CountOfNumbers);

            return (FirstPartSum == SecondPartSum) ? true : false;
        }

        private int SumOfTicketNumbers(int[] array, int start, int end)
        {
            int sum = 0;

            for (int i = start; i < end; i++)
            {
                sum += array[i];
            }

            return sum;
        }
    }
}

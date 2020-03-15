using LuckyTicketsTask.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LuckyTicketsTask.Logic
{
    class MoskowAlgorithm : LuckyTicketAlgorithm
    {
        private readonly int CountOfNumbers = 6;

        public override bool IsLucky(int ticket)
        {
            int FirstPartSum = SumOfTicketNumbers(new Ticket(ticket.ToString()).Number, 0, CountOfNumbers / 2);
            int SecondPartSum = SumOfTicketNumbers(new Ticket(ticket.ToString()).Number, CountOfNumbers / 2, CountOfNumbers);

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

﻿using LuckyTicketsTask.Contracts;
using LuckyTicketsTask.Models;

namespace LuckyTicketsTask.Logic
{
    class MoskowAlgorithm : ILucky
    {
        private const int CountOfNumbers = 6;

        public bool IsLucky(Ticket ticket)
        {
            int FirstPartSum = SumOfTicketNumbers(ticket, 0, CountOfNumbers / 2);
            int SecondPartSum = SumOfTicketNumbers(ticket, CountOfNumbers / 2, CountOfNumbers);

            return FirstPartSum == SecondPartSum;
        }

        private int SumOfTicketNumbers(Ticket ticket, int start, int end)
        {
            int sum = 0;

            for (int i = start; i < end; i++)
            {
                sum += ticket[i];
            }

            return sum;
        }
    }
}

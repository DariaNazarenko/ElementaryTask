using System;
using System.Collections.Generic;
using System.Text;

namespace LuckyTicketsTask.Logic
{
    class LuckyTicketCount
    {
        private int start;
        private int end;
        private LuckyTicketAlgorithm algorithm;

        public LuckyTicketCount(int Start, int End, LuckyTicketAlgorithm Algorithm)
        {
            start = Start;
            end = End;
            algorithm = Algorithm;
        }

        public int CountLuckyTickets()
        {
            int amount = 0;
            for (int i = start; i <= end; i++)
            {
                if (algorithm.IsLucky(i))
                {
                    amount++;
                }
            }

            return amount;
        }
    }
}

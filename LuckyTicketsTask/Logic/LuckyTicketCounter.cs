using LuckyTicketsTask.Contracts;
using LuckyTicketsTask.Models;

namespace LuckyTicketsTask.Logic
{
    class LuckyTicketCounter
    {
        private int start;
        private int end;
        private IAlgorithm algorithm;

        public LuckyTicketCounter(int start, int end, IAlgorithm algorithm)
        {
            this.start = start;
            this.end = end;
            this.algorithm = algorithm;
        }

        public int CountLuckyTickets()
        {
            int amount = 0;
            for (int i = start; i <= end; i++)
            {
                if (algorithm.IsLucky(new Ticket(i.ToString())))
                {
                    amount++;
                }
            }

            return amount;
        }
    }
}

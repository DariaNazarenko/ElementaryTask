using LuckyTicketsTask.Models;

namespace LuckyTicketsTask.Logic
{
    class PiterAlgorithm : LuckyTicketAlgorithm
    {
        public override bool IsLucky(Ticket ticket)
        {
            var sumOfEven = SumOfElements(ticket, 1);
            var sumOfOdd = SumOfElements(ticket, 0);

            return sumOfEven == sumOfOdd;
        }

        private int SumOfElements(Ticket ticket, int startIndex)
        {
            var sum = 0;

            for (int i = startIndex; i < ticket.Length; i += 2)
            {
                sum += ticket[i];
            }

            return sum;
        }
    }
}

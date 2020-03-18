using LuckyTicketsTask.Models;

namespace LuckyTicketsTask.Logic
{
    abstract class LuckyTicketAlgorithm 
    {
        public abstract bool IsLucky(Ticket ticket);
    }
}

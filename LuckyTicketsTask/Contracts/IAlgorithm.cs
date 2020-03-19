using LuckyTicketsTask.Models;

namespace LuckyTicketsTask.Contracts
{
    interface IAlgorithm
    {
        public bool IsLucky(Ticket ticket);
    }
}

using LuckyTicketsTask.Models;

namespace LuckyTicketsTask.Contracts
{
    interface ILucky
    {
        public bool IsLucky(Ticket ticket);
    }
}

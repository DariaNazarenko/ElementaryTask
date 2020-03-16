using LuckyTicketsTask.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LuckyTicketsTask.Logic
{
    abstract class LuckyTicketAlgorithm 
    {
        public abstract bool IsLucky(Ticket ticket);
    }
}

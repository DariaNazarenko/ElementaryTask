﻿using LuckyTicketsTask.LuckyTicketApp;
using System;

namespace LuckyTicketsTask
{
    class Program
    {
        

        static void Main(string[] args)
        {
            try
            {
                Application.Run(args);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }
    }
}

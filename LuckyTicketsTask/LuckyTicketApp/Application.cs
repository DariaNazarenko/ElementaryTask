using LuckyTicketsTask.Logic;
using LuckyTicketsTask.UI;
using ValidationLibrary;
using System;

namespace LuckyTicketsTask.LuckyTicketApp
{
    static class Application
    {
        public static void Run(string[] args)
        {
            Helper.Help();

            var inputStringArray = FileValidator.GetAppropriateStringArrayFromFile(@args[0]);
            LuckyTicketCounter luckyTicketCount = null;

            try
            {
                switch (inputStringArray[0])
                {
                    case "Moskow":
                        luckyTicketCount = new LuckyTicketCounter(Int32.Parse(inputStringArray[1]), Int32.Parse(inputStringArray[2]), new MoskowAlgorithm());
                        break;
                    case "Piter":
                        luckyTicketCount = new LuckyTicketCounter(Int32.Parse(inputStringArray[1]), Int32.Parse(inputStringArray[2]), new PiterAlgorithm());
                        break;
                    default:
                        Console.WriteLine("Ivalid algorithm");
                        break;
                }
                Console.WriteLine(luckyTicketCount.CountLuckyTickets());
            }
            catch (FormatException e)
            {

                Console.WriteLine(e.Message);
            }
        }
    }
}

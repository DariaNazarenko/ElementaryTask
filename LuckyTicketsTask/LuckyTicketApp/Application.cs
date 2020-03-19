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
            var algorithm = inputStringArray[0];
            int startIndex;
            int endIndex;
            LuckyTicketCounter luckyTicketCount = null;

            if(int.TryParse(inputStringArray[1], out startIndex) && int.TryParse(inputStringArray[2], out endIndex) && startIndex <= 999999 && endIndex <= 999999)
            {
                switch (algorithm)
                {
                    case "Moskow":
                        luckyTicketCount = new LuckyTicketCounter(startIndex, endIndex, new MoskowAlgorithm());
                        break;
                    case "Piter":
                        luckyTicketCount = new LuckyTicketCounter(startIndex, endIndex, new PiterAlgorithm());
                        break;
                    default:
                        Console.WriteLine("Ivalid algorithm");
                        break;
                }
                Console.WriteLine(luckyTicketCount.CountLuckyTickets());
            }
            else
            {
                throw new FormatException("Invalid numbers");
            }
        }
    }
}

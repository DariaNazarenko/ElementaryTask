using LuckyTicketsTask.Logic;
using System;
using ValidationLibrary;
using System.Linq;

namespace LuckyTicketsTask
{
    class Program
    {
        static void Help()
        {
            Console.WriteLine("Enter file path in which must be <name of algorithm>, <firs number of ticket>, <last nuber of ticket>.");
        }

        static void Main(string[] args)
        {
            Help();

            var inputStringArray = FileValidator.GetAppropriateStringArrayFromFile(@args[0]);
            LuckyTicketCounter luckyTicketCount = null;

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
    }
}

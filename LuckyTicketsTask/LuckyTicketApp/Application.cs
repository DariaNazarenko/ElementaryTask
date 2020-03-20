using LuckyTicketsTask.Logic;
using LuckyTicketsTask.UI;
using ValidationLibrary;
using System;
using log4net;
using System.Reflection;
using System.IO;

namespace LuckyTicketsTask.LuckyTicketApp
{
    static class Application
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public static void Run(string[] args)
        {
            Helper.Help();
            
            if (File.Exists(@args[0]))
            {
                string fileString;

                using (StreamReader sr = new StreamReader(@args[0]))
                {
                    fileString = sr.ReadToEnd();
                }
                var inputStringArray = new Parser().GetAppropriateStringArray(fileString);
                var algorithm = inputStringArray[0];
                int startIndex;
                int endIndex;

                LuckyTicketCounter luckyTicketCount = null;

                if (int.TryParse(inputStringArray[1], out startIndex) && int.TryParse(inputStringArray[2], out endIndex) && startIndex <= 999999 && endIndex <= 999999)
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
                            log.Warn("Ivalid algorithm");
                            break;
                    }

                    Console.WriteLine(luckyTicketCount.CountLuckyTickets());
                }
                else
                {
                    log.Error(new FormatException("Invalid numbers"));
                    throw new FormatException("Invalid numbers");
                }
            }
            else
            {
                log.Error(new FormatException("Invalid file path"));
                throw new FileNotFoundException("Invalid file path");
            }
           
            
        }
    }
}

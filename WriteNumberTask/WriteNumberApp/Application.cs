using WriteNumberTask.Models;
using WriteNumberTask.Logic;
using ValidationLibrary;
using System;


namespace WriteNumberTask.WriteNumberApp
{
    static class Application
    {
        public static void Run(string[] args)
        {
            Numeric number = new Numeric { Number = Parser.GetIntegerValue(args[0]) };

            var numberConvertor = new NumberConvertor();
            var numberInWords = numberConvertor.WriteNumber(number);

            Console.WriteLine(numberInWords);
        }
    }
}

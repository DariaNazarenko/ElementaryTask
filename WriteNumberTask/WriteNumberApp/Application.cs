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
            Numeric num = new Numeric() { Number = Parser.GetIntegerValue(args) };
            Console.WriteLine(new NumberConvertor().WriteNumber(num));
        }
    }
}

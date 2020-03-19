using FileParserTask.Logic;
using ValidationLibrary;
using FileParserTask.UI;
using System;

namespace FileParserTask.FileParserApp
{
    static class Application
    {
        public static void Run(string[] args)
        {
            var path = @args[0];
            if (FileValidator.CanFindFile(path))
            {
                Helper.Help();
                var taskArgs = Console.ReadLine();
                var taskArgsArray = Parser.GetAppropriateStringArray(taskArgs);
                switch (taskArgsArray.Length)
                {
                    case 1:
                        {
                            Counter counter = new Counter(path);
                            Console.WriteLine(counter.CountStringEnterance(taskArgsArray[0]));
                            break;
                        }
                    case 2:
                        {
                            Replacer replacer = new Replacer(path);
                            replacer.ReplaceString(taskArgsArray[0], taskArgsArray[1]);
                            break;
                        }
                    default:
                        Console.WriteLine("Ivalid task arguments");
                        break;
                }
            }
            else
            {
                Console.WriteLine($"Can`t find file {path}.");
            }
        }
    }
}

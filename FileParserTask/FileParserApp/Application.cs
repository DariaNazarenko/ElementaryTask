using FileParserTask.Logic;
using ValidationLibrary;
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
                Counter counter = new Counter(path);
                Replacer replacer = new Replacer(path);
                Console.WriteLine(counter.CountStringEnterance("hellow"));
                replacer.ReplaceString("hellow", "HI");
                Console.WriteLine(counter.CountStringEnterance("HI"));
            }
            else
            {
                Console.WriteLine($"Can`t find file {path}.");
            }
        }
    }
}

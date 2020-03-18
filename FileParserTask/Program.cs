using FileParserTask.Logic;
using ValidationLibrary;
using System;
using System.IO;

namespace FileParserTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @args[0];
            if (FileValidator.CanFindFile(path))
            {
                FileWorker f = new FileWorker(path);
                Console.WriteLine(f.CountStringEnterance("hellow"));
                f.ReplaceString("hellow", "HI");
                Console.WriteLine(f.CountStringEnterance("HI"));
            }
            else
            {
                Console.WriteLine($"Can`t find file {path}.");
            }
        }
    }
}

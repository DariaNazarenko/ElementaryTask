using System;

namespace FileParserTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = Console.ReadLine();
            FileWorker f = new FileWorker(path);
            Console.WriteLine(f.CountStringEnterance("hellow"));
            f.ReplaceString("hellow", "HI");
            Console.WriteLine(f.CountStringEnterance("hellow"));
        }
    }
}
